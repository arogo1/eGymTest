using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eGym.BLL;
using eGym.BLL.Models.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eGym.WebAPI.Controllers;

[Authorize(Roles = "Admin")]
[ApiController]
[Route("[controller]")]
public class ServiceController : ControllerBase
{
    private readonly IServiceService _service;

    public ServiceController(IServiceService service)
    {
        _service = service;
    }

    [HttpGet]
    [Authorize(Roles = "Admin,Employee,User")]
    public async Task<IActionResult> GetById(int id)
    {
        try
        {
            if(id < 0)
            {
                return BadRequest("Invalid id");
            }

            var response = await _service.GetById(id);
            if(response == null)
            {
                return NotFound("There is no service with provided id");
            }

            return Ok(response);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpGet]
    [Authorize(Roles = "Admin,Employee,User")]
    [Route("getAll")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            return Ok(await _service.GetAll());
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateServiceRequest request)
    {
        try
        {
            await _service.Create(request);

            return Accepted();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateServiceRequest request, int id)
    {
        try
        {
            var service = await _service.GetById(id);
            if(service == null)
            {
                return NotFound("There is no serivce with provided id");
            }

            await _service.Update(request, service);

            return Accepted();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            var service = await _service.GetById(id);
            if (service == null)
            {
                return NotFound("There is no service with provided id");
            }

            await _service.Delete(id);

            return NoContent();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}

