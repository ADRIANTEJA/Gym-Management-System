using Microsoft.AspNetCore.Authorization;

namespace MainModule.Security;

public static class AuthorizationConfig
{
    public static void ConfigureAuthorizationService(this WebApplicationBuilder builder)
    {
        builder.Services.AddAuthorizationBuilder()
            .SetFallbackPolicy(new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build());
    }
}
