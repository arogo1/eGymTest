using eGym.BLL;
using eGym.BLL.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace eGym.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PaymentController : ControllerBase
{
    private readonly IPaymentService _paymentService;

    public PaymentController(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    [HttpGet]
    public async Task<IActionResult> GetWhere()
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
    public async Task<IActionResult> Create(PaymentRequest request)
    {
        try
        {
            await _paymentService.Create(request);

            return Accepted();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}

