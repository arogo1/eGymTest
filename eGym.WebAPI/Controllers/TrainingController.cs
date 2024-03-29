﻿using eGym.BLL;
using eGym.BLL.Implementation;
using eGym.BLL.Models.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace eGym.WebAPI.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class TrainingController : ControllerBase
{
    private readonly ITrainingService _trainingService;
    private readonly IAccountService _accountService;

    public TrainingController(ITrainingService trainingService, IAccountService accountService)
    {
        _trainingService = trainingService;
        _accountService = accountService;
    }

    [HttpGet]
    public async Task<IActionResult> GetById(int id)
    {
        try
        {
            if (id < 0)
            {
                return BadRequest("Invalid id");
            }

            var result = await _trainingService.GetById(id);

            if (result == null)
            {
                return NotFound("Training with provided id doesn't exist");
            }

            return Ok(result);
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }

    [HttpGet]
    [Route("getUserTraningPlan")]
    public async Task<IActionResult> GetUserTraningPlan(int userId)
    {
        try
        {
            if (userId < 0)
            {
                return BadRequest("Invalid id");
            }

            var result = await _trainingService.GetUserTraningPlan(userId);

            if (result == null)
            {
                return NotFound("Trainings for provided user doesn't exist");
            }

            return Ok(result);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateTrainingRequest request)
    {
        try
        {
            var account = await _accountService.GetById(request.AccountId);

            if (account == null)
            {
                return BadRequest("Account with provided id doesn't exist");
            }

            await _trainingService.Create(request);

            return Accepted();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateTrainingRequest request, int trainingId)
    {
        try
        {
            var training = await _trainingService.GetById(trainingId);

            if (training == null)
            {
                return BadRequest("Training with provided id doesn't exist");
            }

            await _trainingService.Update(request, training);

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
            if (id < 0)
            {
                return BadRequest("Invalid id");
            }

            await _trainingService.Delete(id);

            return NoContent();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}

