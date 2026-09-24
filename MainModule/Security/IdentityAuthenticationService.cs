using MainModule.Dtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MainModule.Security;

public class IdentityAuthenticationService : IAuthenticationService
{
    private readonly IPasswordHasher<string> _passwordHasher;

    private readonly JwtOptions _jwtOptions;

    public IdentityAuthenticationService(IPasswordHasher<string> passwordHasher, IOptions<JwtOptions> jwtOptions)
    {
        _passwordHasher = passwordHasher;
        _jwtOptions = jwtOptions.Value;
    }

    public string AuthenticateUser(string textPassword, string hashedPassword)
    {
        throw new NotImplementedException();
    }

    public PasswordVerificationResult UserPasswordVerification(string hashedPassword, string unhashedPassword)
    {
        return _passwordHasher.VerifyHashedPassword(string.Empty, hashedPassword, unhashedPassword);
    }

    public string HashUserPassword(string unhashedPassword)
    {
       return _passwordHasher.HashPassword(string.Empty, unhashedPassword);
    }

    //only issued for user login after registration,
    public string GeneratePasswordCreationToken(UserSignUpDto dto)
    {
        var secretKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(_jwtOptions.SecretKey));

        var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

        var claims = new List<Claim>
        {
            new ("phase", "email_verification"),
            new ("fullName", dto.FullName),
            new ("age", dto.Age.ToString()),
            new ("phoneNumber", dto.PhoneNumber),
            new ("personalId", dto.PersonalId),
            new (JwtRegisteredClaimNames.Sub, dto.EmailAddress)
        };

        var token = new JwtSecurityToken(
            issuer: _jwtOptions.Issuer,
            audience: _jwtOptions.Audience,
            claims: claims,
            notBefore: DateTime.UtcNow,
            expires: DateTime.Now.AddMinutes(_jwtOptions.RegistrationTokenExpMinutes),
            signingCredentials: signinCredentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}

