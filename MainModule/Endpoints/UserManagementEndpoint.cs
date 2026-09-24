using DataAccess.DataAccess;
using DataAccess.Models;
using MainModule.Dtos;
using MainModule.Emailing;
using MainModule.Security;
using Microsoft.AspNetCore.Mvc;

namespace MainModule.Endpoints;

public static class UserManagementEndpoint
{
    private record SignUpResponse(UserSignUpDto userData, string SignUpToken);

    private record VerifyEmailDto(string email, string password);

    public static void MapAuthenticationEndpoints(this WebApplication app)
    {
        app.MapPost("/api/auth/register", RegisterUser)
           .AllowAnonymous();
        app.MapPost("api/auth/emailVerification", VerifyUserEmail)
           .AllowAnonymous();
        //app.MapPost("/api/auth/passwordCreation", )
    }

    private static async Task<IResult> VerifyUserEmail([FromBody] UserSignUpDto dto,
                                                       [FromServices] IEmailService emailService,
                                                       [FromServices] ILogger<MailKitEmailService> mailServicelogger,
                                                       [FromServices] IAuthenticationService authService)
    {
        var emailVerificationData = new EmailData
        {
            EmailFromAddress = "from@example.com",
            EmailToAddress = dto.EmailAddress,
            EmailFromName = "John Smith",
            EmailToName = dto.FullName,
            EmailSubject = "verification",
            EmailBody = "verification email, do not reply"
        };

        // Verifies if the user email address is valid
        try
        {
            if (emailService.SendEmail(emailVerificationData) != MailKitEmailService.EmailStatus.Success.ToString())
            {
                return Results.BadRequest("Invalid email address");
            }
        }
        catch (Exception ex)
        {
            mailServicelogger.LogError("Error verifying email address: {Message}", ex.Message);

            return Results.BadRequest("Error verifying email address");
        }

        // if the email is valid, generate a sign-up token the user will need to sign in
        return Results.Ok(authService.GeneratePasswordCreationToken(dto));
    }

    private static async Task<IResult> CreateUserPassword()
    {
        throw new NotImplementedException();
    }

    private static async Task<IResult> RegisterUser([FromBody] UserSignUpDto dto,
                                                  [FromServices] UserCredentialsData userCredentialsData,
                                                  [FromServices] MemberData memberData,
                                                  [FromServices] IAuthenticationService authService)
    {
        var newMember = new MemberModel
        {
            FullName = dto.FullName,
            Age = dto.Age,
            PhoneNumber = dto.PhoneNumber,
            PersonalId = dto.PersonalId,
        };

        var userCredentials = new UserCredentialsModel
        {
            EmailAddress = dto.EmailAddress,
            HashedPassword = authService.HashUserPassword(dto.Password)
        };

        //newMember.UserCredentialsId = await userCredentialsData.CreateUserCredentials()

        //var responseBody = new SignUpResponse(dto, signUpToken);

        return await memberData.CreateMember(newMember) > 0 ? Results.Ok(/*responseBody*/) :
            Results.BadRequest("Failed to create member");
    }
}
