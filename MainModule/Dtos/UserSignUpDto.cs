using System.ComponentModel.DataAnnotations;

namespace MainModule.Dtos;

public class UserSignUpDto
{
    [Required]
    public string FullName { get; set; }

    [Required]
    public int Age { get; set; }

    [Required]
    public string PhoneNumber { get; set; }

    [Required]
    public string PersonalId { get; set; }

    [Required]
    [EmailAddress(ErrorMessage = "Invalid email address format.")]
    public string EmailAddress { get; set; }

    [Required]
    public string Password { get; set; }
}
