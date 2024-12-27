using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.RecruitNotificationSettings.Commands.CreateRecruitNotificationSetting;
using Settings.Application.Features.RecruitNotificationSettings.Commands.DeleteRecruitNotificationSetting;
using Settings.Application.Features.RecruitNotificationSettings.Commands.UpdateRecruitNotificationSetting;
using Settings.Application.Features.RecruitNotificationSettings.Queries.GetAllRecruitNotificationSettings;
using Settings.Application.Features.RecruitNotificationSettings.Queries.GetRecruitNotificationSettingById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RecruitNotificationSettingController : ControllerBase
{
    private readonly IMediator _mediator;
    public RecruitNotificationSettingController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var recruitNotificationSettingList = await _mediator.Send(new GetAllRecruitNotificationSettingsQuery());
        return Ok(recruitNotificationSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var recruitNotificationSetting = await _mediator.Send(new GetRecruitNotificationSettingByIdQuery { Id = Id });
        if (recruitNotificationSetting is not null) { return Ok(recruitNotificationSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateRecruitNotificationSettingCommand command)
    {
        await _mediator.Send(command);
        return Ok("RecruitNotificationSetting Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateRecruitNotificationSettingCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteRecruitNotificationSettingCommand { Id = Id });
        return NoContent();
    }
}














