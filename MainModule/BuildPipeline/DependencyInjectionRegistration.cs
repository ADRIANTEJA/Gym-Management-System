using DataAccess;
using DataAccess.DataAccess;
using MainModule.Authentication;
using MainModule.Debug;
using MainModule.Endpoints;
using MainModule.Security;

namespace MainModule.BuildPipeline;

public static class DependencyInjectionRegistration
{
    public static void AddServices(this WebApplicationBuilder builder)
    {
        //Service Configuration
        builder.ConfigureCorsService();
        builder.ConfigureAuthenticationService();
        builder.ConfigureAuthorizationService();
        builder.Services.ConfigureOpenApiService();

        //Service Registration
        builder.Services.AddSingleton<ConnectionStringData>();
        builder.Services.AddSingleton<ISQLDataAccess, SQLServerAccess>();
        builder.Services.AddSingleton<MemberData>();
        builder.Services.AddSingleton<UserCredentialsData>();
    }
}
