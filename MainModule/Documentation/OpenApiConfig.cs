using Scalar.AspNetCore;

namespace MainModule.Debug;

public static class OpenApiConfig
{
    public static void ConfigureOpenApiService(this IServiceCollection services)
    {
        services.AddOpenApi();
    }

    public static void UseOpenApi(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
            app.MapScalarApiReference(options =>
            {
                options.Title = "Gym Management System Main Module";
                options.HideClientButton = true;
                options.Layout = ScalarLayout.Modern;
            });
        }
    }
}
