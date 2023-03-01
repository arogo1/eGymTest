namespace eGym.BLL;

public interface IReservationService
{
    public Task GetById(int id);
    public Task Delete(int id);
    public Task Create();
    public Task Update();
}

