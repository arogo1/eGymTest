using eGym.BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eGym.WebAPI.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class RecommendationController : ControllerBase
{
    private readonly IRecommendationService _recommendationService;

    public RecommendationController(IRecommendationService recommendationService)
    {
        _recommendationService = recommendationService;
    }

    public async Task<IActionResult> Get()
    {
        try
        {
            var response = await _recommendationService.Get();

            return Ok(response);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}

