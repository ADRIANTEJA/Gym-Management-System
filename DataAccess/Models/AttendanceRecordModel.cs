using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models;

public class AttendanceRecordModel(int memberId)
{

    public int? Id { get; init; }

    public int MemberId { get; set; } = memberId;

    [Required]
    public string MemberFullName { get; set; }

    [Required]
    public DateTime DateAndTime { get; set; }

    [Required]
    public bool IsScheduled { get; set; }
}
