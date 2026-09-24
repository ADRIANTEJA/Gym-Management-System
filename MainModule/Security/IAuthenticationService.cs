using MainModule.Dtos;
using Microsoft.AspNetCore.Identity;

namespace MainModule.Security;

public interface IAuthenticationService
{
    string AuthenticateUser(string textPassword, string hashedPassword);

    string HashUserPassword(string unhashedPassword);

    PasswordVerificationResult UserPasswordVerification(string textPassword, string hashedPassword);

    string GeneratePasswordCreationToken(UserSignUpDto dto);
}
