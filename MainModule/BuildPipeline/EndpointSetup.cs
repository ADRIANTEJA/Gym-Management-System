using MainModule.Endpoints;

namespace MainModule.BuildPipeline;

public static class EndpointSetup
{
    public static void AddEndpoints(this WebApplication app)
    {
        app.MapMemberEndpoints();
        app.MapLoginEndpoints();
    }
}
