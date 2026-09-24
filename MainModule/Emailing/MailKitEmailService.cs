using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using MailKit;
using MailKit.Security;

namespace MainModule.Emailing;

public class MailKitEmailService : IEmailService
{
    private readonly MailKitOptions _emailOptions;
    private readonly ILogger<MailKitEmailService> _logger;

    public enum EmailStatus
    {
        Success,
        Failure
    }

    public MailKitEmailService(IOptions<MailKitOptions> emailOptions, ILogger<MailKitEmailService> logger)
    {
        _emailOptions = emailOptions.Value;
        _logger = logger;
    }

    public string SendEmail(EmailData emailData)
    {
        var message = new MimeMessage();

        var emailFrom = new MailboxAddress(emailData.EmailFromName,
                                           emailData.EmailFromAddress);

        var emailTo = new MailboxAddress(emailData.EmailToName,
                                         emailData.EmailToAddress);

        message.From.Add(emailFrom);
        message.To.Add(emailTo);

        message.Subject = emailData.EmailSubject;

        var bodyBuilder = new BodyBuilder
        {
            TextBody = emailData.EmailBody
        };

        message.Body = bodyBuilder.ToMessageBody();

        try
        {
            using var emailClient = new SmtpClient();
            emailClient.Connect(_emailOptions.Host,
                                _emailOptions.Port,
                                _emailOptions.EncryptionOptions);

            emailClient.Authenticate(_emailOptions.UserName,
                                     _emailOptions.Password);

            emailClient.Send(message);
            emailClient.Disconnect(true);

            return EmailStatus.Success.ToString();
        }
        catch (Exception ex) when (ex is ProtocolException 
                                   || ex is SmtpProtocolException
                                   || ex is SslHandshakeException
                                   || ex is AuthenticationException
                                   || ex is ServiceNotConnectedException)
        {
            _logger.LogError("Error sending email: {Message}", ex.Message);

            return EmailStatus.Failure.ToString() + ": " + ex.Message;
            throw;
        }
    }
}
