using System.ComponentModel.DataAnnotations;

namespace MainModule.Dtos;

public class MemberDto
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
    public int UserCredentialsId { get; set; }
}
