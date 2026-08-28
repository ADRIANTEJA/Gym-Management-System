using DataAccess;
using DataAccess.DataAccess;
using MainModule.Authentication;
using MainModule.Endpoints;

namespace MainModule.BuildPipeline;

public static class DependencyInjection
{
    public static void AddServices(this WebApplicationBuilder builder)
    {
        builder.AddCorsService();
        //builder.AddAuthentication();
        builder.Services.AddOpenApiServices();
        builder.Services.AddSingleton<ConnectionStringData>();
        builder.Services.AddSingleton<ISQLDataAccess, SQLServerAccess>();
        builder.Services.AddSingleton<MemberData>();
        builder.Services.AddSingleton<UserCredentialsData>();
    }
}
