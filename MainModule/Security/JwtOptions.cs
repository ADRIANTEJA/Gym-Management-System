using System.ComponentModel.DataAnnotations;

namespace MainModule.Security;

public class JwtOptions
{
    [Required]
    public string SecretKey { get; set; }
    [Required]
    public string Issuer { get; set; }
    [Required]
    public string Audience { get; set; }
    [Required]
    public int RegistrationTokenExpMinutes { get; set; }
}
