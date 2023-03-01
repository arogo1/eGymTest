using eGym.BLL;
using Microsoft.AspNetCore.Mvc;

namespace eGym.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class DietController : ControllerBase
{
    private readonly IDietService _dietService;

    public DietController(IDietService dietService)
    {
        _dietService = dietService;
    }

    [HttpGet]
    public async Task<IActionResult> GetById(int id)
    {
        try
        {
            return Ok();
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
            return NoContent();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpPut]
    public async Task<IActionResult> Update()
    {
        try
        {
            return Accepted();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpPost]
    public async Task<IActionResult> Create()
    {
        try
        {
            return Accepted();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}

