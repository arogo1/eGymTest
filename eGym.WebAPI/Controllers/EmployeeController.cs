using eGym.BLL;
using eGym.BLL.Implementation;
using eGym.BLL.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace eGym.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet]
    public async Task<IActionResult> GetById(int id)
    {
        try
        {
            if(id < 0)
            {
                return BadRequest("Invalid id");
            }

            var response = await _employeeService.GetById(id);
            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            if (id < 0)
            {
                return BadRequest("Invalid id");
            }

            //Check if account exist
            var employee = await _employeeService.GetById(id);
            if (employee == null)
            {
                return NotFound("Account with given Id doesn't exist");
            }

            await _employeeService.Delete(id);

            return NoContent();
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateAccountRequest request, int id)
    {
        try
        {
            var employee = await _employeeService.GetById(id);
            if (employee == null)
            {
                return NotFound("Account with given Id doesn't exist");
            }

            await _employeeService.Update(request, employee);

            return Ok();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateEmployeeRequest request)
    {
        try
        {
            await _employeeService.Create(request);

            return Accepted();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}

