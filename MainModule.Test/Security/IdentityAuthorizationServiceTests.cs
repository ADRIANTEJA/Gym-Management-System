using MainModule.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Moq;
namespace MainModule.Test.Security;

public class IdentityAuthorizationServiceTests
{
    [Fact]
    public void VerifyHashedPassword_ShouldReturnSuccessWithoutNeedForUserParameter()
    {
        // Arrange
        var mockJWTOptions = new Mock<IOptions<JwtOptions>>();

        var authenticationService = new IdentityAuthenticationService(new PasswordHasher<string>(),
                                                                      mockJWTOptions.Object);

        string unhashedPassword = "secure123.";

        // Act
        string hashedPassword = authenticationService.HashUserPassword(unhashedPassword);

        // Assert
        Assert.Equal(PasswordVerificationResult.Success,
                     authenticationService.UserPasswordVerification(hashedPassword, unhashedPassword));
    }
}
