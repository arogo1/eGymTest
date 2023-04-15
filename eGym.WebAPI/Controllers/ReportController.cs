using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eGym.WebAPI.Controllers;

[Authorize(Roles = "Admin")]
[ApiController]
[Route("[controller]")]
public class ReportController : ControllerBase
{
    [Route("finance")]
    [HttpGet]
    public IActionResult GetFinancialReport(DateTime from, DateTime to)
    {
        return Ok();
    }

    [Route("employees")]
    [HttpGet]
    public IActionResult GetEmployeesReport(DateTime from, DateTime to)
    {
        return Ok();
    }

    [Route("users")]
    [HttpGet]
    public IActionResult GetUsersReport(DateTime from, DateTime to)
    {
        return Ok();
    }
}

