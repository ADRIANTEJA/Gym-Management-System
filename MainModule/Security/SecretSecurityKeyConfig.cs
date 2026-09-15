using System.Security.Cryptography;

namespace MainModule.Security;

public static class SecretSecurityKeyConfig
{
    public static void ConfigureSecretSecurityKey(this WebApplicationBuilder builder)
    {
        builder.Configuration["JwtOptions:SecretKey"] = GenerateSecretSecurityKey();
    }

    public static string GenerateSecretSecurityKey()
    {
        var secretkeyBytes = new byte[32];

        RandomNumberGenerator.Fill(secretkeyBytes);

        return Convert.ToBase64String(secretkeyBytes);
    }
}
