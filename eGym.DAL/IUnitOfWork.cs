namespace eGym.DAL;

public interface IUnitOfWork : IDisposable
{
    IAccountRepository Accounts { get; }
    IEmployeeRepository Employees { get; }
    IFeedbackRepository Feedbacks { get; }
    IDietRepository Diets { get; }
    IReservationRepository Reservations { get; }

    int Complete();
}