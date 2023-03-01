using eGym.BLL;
using eGym.BLL.Models.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eGym.Controllers;

//[Authorize]
[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
    }

    [HttpGet]
    public async Task<IActionResult> GetById([FromQuery] int id)
    {
        try
        {
            if (id <= 0)
            {
                return BadRequest("Invalid Id");
            }

            var response = await _accountService.GetById(id);
            if (response == null)
            {
                return NotFound("Account with provided Id doesn't exist");
            }

            return Ok(response);
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
            if(id <= 0)
            {
                return BadRequest("Invalid Id");
            }

            //Check if account exist
            var account = await _accountService.GetById(id);
            if (account == null)
            {
                return NotFound("Account with given Id doesn't exist");
            }

            await _accountService.Delete(id);

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
            var account = await _accountService.GetById(id);
            if(account == null)
            {
                return NotFound("Account with given Id doesn't exist");
            }

            await _accountService.Update(request, account);

            return Ok();
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateAccountRequest request)
    {
        try
        {
            await _accountService.Create(request);

            return Accepted();
        }
        catch(Exception ex)
        {
            throw ex;
        }
        
    }

    /*[HttpPost]
    [Route("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        try
        {
            await _accountService.Login(request);

            return Ok();
        }
        catch(Exception ex)
        {
            throw ex;
        }
        
    }*/
}

