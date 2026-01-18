

using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models;

public class TrainingSessionModel(int trainerId)
{
    public int? Id { get; init; }

    public int TrainerId { get; } = trainerId;

    [Required]
    public DateTime ScheduleDate { get; set; }

    public string? SessionDescription { get; set; }
}
