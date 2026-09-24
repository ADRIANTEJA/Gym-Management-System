namespace MainModule.Emailing;

public static class MailKitEmailConfig
{
    public static void ConfigureMailKitEmailService(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<MailKitOptions>(builder.Configuration.GetSection(nameof(MailKitOptions)));
    }
}
