using eGym.BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eGym.WebAPI.Controllers;

[Authorize(Roles = "Admin")]
[ApiController]
[Route("[controller]")]
public class ReportController : ControllerBase
{
    private readonly IReportService _reportService;

    public ReportController(IReportService reportService)
    {
        _reportService = reportService;
    }

    [Route("finance")]
    [HttpGet]
    public async Task<IActionResult> GetFinancialReport()
    {
        try
        {
            var file = await _reportService.GetFinanceReport();

            return File(file, "application/pdf");
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [Route("employees")]
    [HttpGet]
    public async Task<IActionResult> GetEmployeesReport()
    {
        try
        {
            var file = await _reportService.GetEmployeeReport();

            return File(file, "application/pdf");
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [Route("users")]
    [HttpGet]
    public async Task<IActionResult> GetUsersReport(DateTime from, DateTime to)
    {
        try
        {
            var file = await _reportService.GetUserReport();

            return File(file, "application/pdf");
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}

