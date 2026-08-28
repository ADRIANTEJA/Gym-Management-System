using Microsoft.AspNetCore.Mvc;

namespace MainModule.Endpoints;

public static class LoginEndpoint
{
    public static void MapLoginEndpoints(this WebApplication app)
    {
       app.MapGet("/api/user/login", LoginUser);
    }

    public async static Task<IResult> LoginUser()
    {
        return Results.Unauthorized();
    }
}
