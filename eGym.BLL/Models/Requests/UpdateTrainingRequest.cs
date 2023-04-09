namespace eGym.BLL.Models.Requests;

public class UpdateTrainingRequest : CreateTrainingRequest
{
    public int TrainingId { get; set; }
}