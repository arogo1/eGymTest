using System;
using eGym.BLL.Models;
using eGym.DAL;

namespace eGym.BLL.Implementation;

public class ReportService : IReportService
{
    private readonly IUnitOfWork _unitOfWork;

	public ReportService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
	}

    public EmployeeReport GetEmployeeReport(DateTime from, DateTime to)
    {
        throw new NotImplementedException();
    }

    public FinanceReport GetFinanceReport(DateTime from, DateTime to)
    {
        throw new NotImplementedException();
    }

    public UserReport GetUserReport(DateTime from, DateTime to)
    {
        throw new NotImplementedException();
    }
}

