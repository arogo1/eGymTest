using eGym.DAL.Repository;

namespace eGym.DAL.Implementation;

public class UnitOfWork : IUnitOfWork
{
	private readonly DataBaseContext _context;

	public UnitOfWork(DataBaseContext context)
	{
		_context = context;
        Accounts = new AccountRepository(_context);
        Employees = new EmployeeRepository(_context);
        Feedbacks = new FeedbackRepository(_context);
    }

    public IAccountRepository Accounts { get; private set; }
    public IEmployeeRepository Employees { get; private set; }
    public IFeedbackRepository Feedbacks { get; private set; }

    public int Complete()
    {
        return _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}

