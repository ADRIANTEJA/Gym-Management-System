using MainModule.DataAccess;
using MainModule.Documentation;
using MainModule.Emailing;
using MainModule.Security;

namespace MainModule.BuildPipeline;

public static class ServiceConfiguration
{
    public static void ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.ConfigureCorsService();
        builder.ConfigureAuthenticationService();
        builder.ConfigureAuthorizationService();
        builder.Services.ConfigureOpenApiService();
        builder.ConfigureMailKitEmailService();
        builder.ConfigureDataAccessService();
    }
}
