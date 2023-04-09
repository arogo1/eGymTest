namespace eGym.BLL.Models.Requests;

public class CreateTrainingRequest
{
    public int AccountId { get; set; }
    public DayOfWeek Day { get; set; }
    public string? Description { get; set; }
}

