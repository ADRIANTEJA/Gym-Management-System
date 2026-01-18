

namespace DataAccess.Models;

public class ScheduleModel(int memberId, int trainingSessionId)
{
    public int MemberId { get; set; } = memberId;

    public int TrainingSessionId { get; set; } = trainingSessionId;
}
