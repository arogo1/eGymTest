using eGym.BLL.Models.Enums;

namespace eGym.BLL.Models.Requests;

public class CreateDietRequest
{
    public int AccountId { get; set; }
    public DayOfWeek Day { get; set; }
    public Meal Meal { get; set; }
    public string? Description { get; set; }
}

