using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.BLL;

public interface IReservationService
{
    public Task<ReservationDTO> GetById(int id);
    public Task<List<ReservationDTO>> GetByUser(int userId);
    public Task<List<ReservationDTO>> GetByEmployee(int employeeId);
    public Task Delete(int id);
    public Task Create(CreateReservationRequest request);
    public Task Update(UpdateReservationRequest request, ReservationDTO reservation);
    public Task UpdateStatus(ReservationDTO reservation);
}

