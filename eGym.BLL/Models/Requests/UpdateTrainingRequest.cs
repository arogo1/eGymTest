namespace eGym.BLL.Models.Requests;

public class UpdateTrainingRequest : CreateTrainingRequest
{
    public DayOfWeek? Day { get; set; }
    public string? Description { get; set; }
}