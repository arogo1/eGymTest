using eGym.BLL.Models.Enums;

namespace eGym.BLL.Models.Requests;

public class CreateReservationRequest
{
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public string? Description { get; set; }
    public int AccountId { get; set; }
    public int EmployeeId { get; set; }
}

