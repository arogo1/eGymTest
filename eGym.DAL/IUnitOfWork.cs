namespace eGym.DAL;

public interface IUnitOfWork : IDisposable
{
    IAccountRepository Accounts { get; }
    IEmployeeRepository Employees { get; }
    IFeedbackRepository Feedbacks { get; }

    int Complete();
}