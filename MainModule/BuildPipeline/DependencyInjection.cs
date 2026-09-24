using DataAccess;
using DataAccess.Configuration;
using DataAccess.DataAccess;
using MainModule.Emailing;
using Microsoft.AspNetCore.Identity;

namespace MainModule.BuildPipeline;

public static class DependencyInjection
{
    public static void AddServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<IPasswordHasher<string>, PasswordHasher<string>>();
        builder.Services.AddSingleton<IEmailService, MailKitEmailService>();
        builder.Services.AddSingleton<ISQLDataAccess, SQLServerAccess>();
        builder.Services.AddSingleton<MemberData>();
        builder.Services.AddSingleton<UserCredentialsData>();
    }
}
