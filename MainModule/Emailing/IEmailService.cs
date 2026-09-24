namespace MainModule.Emailing;

public interface IEmailService
{
    string SendEmail(EmailData emailData);
}
