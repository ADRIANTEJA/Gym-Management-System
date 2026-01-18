using DataAccess;

namespace MainModule.BuildPipeline;

public static class DependencyInjection
{
    public static void AddServices(this WebApplicationBuilder builder)
    {
        builder.AddCorsService();
        builder.Services.AddOpenApiServices();
        builder.Services.AddSingleton<ConnectionStringData>();
    }
}
