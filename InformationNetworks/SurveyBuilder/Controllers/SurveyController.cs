using Mapster;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SurveyBuilder.Controllers.Dtos;
using SurveyBuilder.Domain.Commands;
using SurveyBuilder.Domain.Models;
using SurveyBuilder.Domain.Queries;

namespace SurveyBuilder.Controllers;

[Authorize]
public class SurveyController(IMediator mediator, UserManager<ApplicationUser> userManager) : Controller
{
    [HttpGet]
    public IActionResult Create()
    {
        return View(new CreateSurveyDto());
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateSurveyDto dto)
    {
        if (ModelState.IsValid)
        {
            var userId = userManager.GetUserId(User);
            var command = dto.Adapt<CreateSurveyCommand>() with { UserId = userId };

            await mediator.Send(command);
            return RedirectToAction("Browse", "Survey");;
        }
        return View(dto);
    }

    [HttpGet]
    public async Task<IActionResult> Browse()
    {
        var surveys = await mediator.Send(new GetAllSurveysQuery());
        return View(surveys.Adapt<IEnumerable<SurveyDto>>());
    }

    [HttpGet]
    public async Task<IActionResult> Take(string id)
    {
        var survey = await mediator.Send(new GetSurveyQuery(id));
        if (survey == null)
        {
            return NotFound();
        }

        return View(survey.Adapt<SurveyDto>());
    }

    [HttpPost]
    public async Task<IActionResult> Take(TakeSurveyDto dto)
    {
        if (ModelState.IsValid)
        {
            var userId = userManager.GetUserId(User);
            var command = dto.Adapt<CreateResponseCommand>() with { UserId = userId };

            await mediator.Send(command);
        }

        return RedirectToAction(nameof(Browse));
    }
}