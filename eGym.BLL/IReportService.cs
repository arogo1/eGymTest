namespace eGym.BLL;

public interface IReportService
{
    public Task<byte[]> GetUserReport();
    public Task<byte[]> GetFinanceReport();
    public Task<byte[]> GetEmployeeReport();
}

