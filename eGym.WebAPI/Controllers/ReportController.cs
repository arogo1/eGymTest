using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eGym.WebAPI.Controllers;

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

