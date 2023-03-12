using AutoMapper;
using eGym.BLL.Models;
using eGym.BLL.Models.Requests;
using eGym.DAL;
using eGym.Domain;

namespace eGym.BLL.Implementation;

public class ReservationService : IReservationService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

	public ReservationService(IUnitOfWork unitOfWork, IMapper mapper)
	{
        _unitOfWork = unitOfWork;
        _mapper = mapper;
	}

    public async Task Create(CreateReservationRequest request)
    {
        var reservation = _mapper.Map<Reservation>(request);
        reservation.Status = 1;
        await _unitOfWork.Reservations.Insert(reservation);
    }

    public async Task Delete(int id)
    {
        await _unitOfWork.Reservations.Delete(id);
    }

    public async Task Update(UpdateReservationRequest request, ReservationDTO reservation)
    {
        var updatedReservation = _mapper.Map(request, reservation);
        await _unitOfWork.Reservations.Update(_mapper.Map<Reservation>(updatedReservation));
    }

    public async Task<ReservationDTO> GetById(int id)
    {
        var result = await _unitOfWork.Reservations.GetById(id);
        return _mapper.Map<ReservationDTO>(result);
    }

    public async Task<List<ReservationDTO>> GetByUser(int userId)
    {
        var result = await _unitOfWork.Reservations.GetWhere(x => x.AccountId.Equals(userId));
        return _mapper.Map<List<ReservationDTO>>(result);
    }

    public async Task<List<ReservationDTO>> GetByEmployee(int employeeId)
    {
        var result = await _unitOfWork.Reservations.GetWhere(x => x.AccountId.Equals(employeeId));
        return _mapper.Map<List<ReservationDTO>>(result);
    }

    public async Task UpdateStatus(ReservationDTO reservation)
    {
        await _unitOfWork.Reservations.Update(_mapper.Map<Reservation>(reservation));
    }
}

