using Microsoft.AspNetCore.Mvc;

namespace MainModule.Endpoints;

public static class LoginEndpoint
{
    public static void MapLoginEndpoints(this WebApplication app)
    {
       app.MapGet("/api/user/login", LoginUser)
            .AllowAnonymous();
    }

    public async static Task<IResult> LoginUser()
    {
        // Implement your login logic here, e.g., validate user credentials, generate JWT token, etc elswhere
        return Results.Unauthorized();
    }
}
