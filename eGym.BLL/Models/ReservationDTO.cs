using eGym.BLL.Models.Enums;

namespace eGym.BLL.Models;

public class ReservationDTO
{
    public int ResevationId { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public string? Description { get; set; }
    public ReservationStatus Status { get; set; }
    public int AccountId { get; set; }
    public int EmployeeId { get; set; }
}

