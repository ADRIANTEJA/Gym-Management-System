using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models;

public class UserCredentialsModel
{
    public int? Id { get; init; }

    [Required]
    [EmailAddress]
    public string EmailAddress { get; set; }

    [Required]
    public string Password { get; set; }
}
