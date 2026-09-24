using MailKit.Security;
using MainModule.Emailing;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;

namespace MainModule.Test.Emailing;

public class MailKitEmailServiceTests
{
    [Fact]
    private void SendEmail_ShouldReturnSuccess_WhenEmailIsSent()
    {
        // Arrange
        var mockLogger = new Mock<ILogger<MailKitEmailService>>();

        var mockMailKitOptions = new Mock<IOptions<MailKitOptions>>();

        mockMailKitOptions.SetupGet(x => x.Value).Returns(new MailKitOptions
        {
            Host = "sandbox.smtp.mailtrap.io",
            Port = 587,
            EncryptionOptions = SecureSocketOptions.StartTls,
            UserName = "3ab03757f11740",
            Password = "9800d22a106751"
        });

        var emailService = new MailKitEmailService(mockMailKitOptions.Object, mockLogger.Object);

        var expected = MailKitEmailService.EmailStatus.Success.ToString();

        // Act
        var result = emailService.SendEmail(new EmailData
        {
            EmailFromAddress = "from@example.com",
            EmailToAddress = "adriantejablanco.ds@gmail.com",
            EmailFromName = "John Smith",
            EmailToName = "Adrian Teja",
            EmailSubject = "some subject",
            EmailBody = "somebody call somebody"
        });

        // Assert
        Assert.Equal(expected, result);
    }
}
