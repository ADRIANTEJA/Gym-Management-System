namespace MainModule.BuildPipeline;

public static class CorsConfig
{
    private const string AllowDevServerPolicy = "AllowDevServer";
    private const string DefProductionServerPolicy = "DefaultServerPolicy";

    public static void AddCorsService(this WebApplicationBuilder builder)
    {
        string? origins = builder.Configuration.GetValue<string>("AllowedOrigins"); 

        builder.Services.AddCors(options =>
        {
            if (!string.IsNullOrEmpty(origins))
            {
                options.AddPolicy(AllowDevServerPolicy, policy =>
                {
                    policy.WithOrigins(origins.Split(";"))
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });

                options.AddPolicy(DefProductionServerPolicy, policy =>
                {
                    policy.WithOrigins(origins.Split(";"));
                });
            }
        });
    }

    public static void UseCors(this WebApplication app)
    {
        if (app.Environment.IsDevelopment()) app.UseCors(AllowDevServerPolicy);
        else app.UseCors(DefProductionServerPolicy);
    }
}
