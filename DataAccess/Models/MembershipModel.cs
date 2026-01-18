

using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models;

public class MembershipModel(int memberId)
{
    public int? Id { get; init; }

    public int MemberId { get; } = memberId;

    [Required]
    public DateTime ExpeditionDate { get; set; }

    [Required]
    public DateTime ExpirationDate { get; set; }

    [Required]
    public double BillAmount { get; set; }

    [Required]
    public MembershipStatus Status { get; set; }

    [Required]
    public MembershipType Type { get; set; }

    public enum MembershipStatus
    {
        Active,
        Inactive,
        Suspended
    }

    public enum MembershipType
    {
        Basic
    }
}
