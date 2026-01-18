using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models;

public class MemberModel
{
    public int? Id { get; init; }

    [Required]
    public string FullName { get; set; }

    [Required]
    public int Age { get; set; }

    [Required]
    public string PhoneNumber { get; set; }

    [Required]
    public string PersonalId { get; set; }

    [Required]
    public string UserCredentialsId { get; set; }
}
