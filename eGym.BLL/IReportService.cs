using System;
using eGym.BLL.Models;

namespace eGym.BLL;

public interface IReportService
{
    public UserReport GetUserReport(DateTime from, DateTime to);
    public FinanceReport GetFinanceReport(DateTime from, DateTime to);
    public EmployeeReport GetEmployeeReport(DateTime from, DateTime to);
}

