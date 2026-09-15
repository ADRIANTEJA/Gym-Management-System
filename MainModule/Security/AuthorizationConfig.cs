using Microsoft.AspNetCore.Authorization;

namespace MainModule.Security;

public static class AuthorizationConfig
{
    public static void ConfigureAuthorizationService(this WebApplicationBuilder builder)
    {
        builder.Services.AddAuthorization(options =>
        {
            options.FallbackPolicy =  new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();
        });
    }
}
