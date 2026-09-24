using MailKit.Security;
using System.ComponentModel.DataAnnotations;

namespace MainModule.Emailing;

public class MailKitOptions
{
    [Required]
    public string Host { get; set; }
    [Required]
    public int Port { get; set; }
    [Required]
    public SecureSocketOptions EncryptionOptions { get; set; }
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
}
