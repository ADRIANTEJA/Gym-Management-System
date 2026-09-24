using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace MainModule.Security;

public static class AuthenticationConfig
{
    public static void ConfigureAuthenticationService(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection(nameof(JwtOptions)));

        builder.Services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new()
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = builder.Configuration.GetSection("JwtAuthentication:Issuer").Value,
                ValidAudience = builder.Configuration.GetSection("JwtAuthentication:Audience").Value,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("JwtAuthentication:SecretKey").Value!))
            };
        });
    }
}
