using DataAccess.Configuration;

namespace MainModule.DataAccess;

public static class DataAccessConfig
{
    public static void ConfigureDataAccessService(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<ConnectionStringOptions>(builder.Configuration.GetSection(nameof(ConnectionStringOptions)));
    }
}
