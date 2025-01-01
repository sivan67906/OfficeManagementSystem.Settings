using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.RecruitFooterSettings.Commands.CreateRecruitFooterSetting;
using Settings.Application.Features.RecruitFooterSettings.Commands.DeleteRecruitFooterSetting;
using Settings.Application.Features.RecruitFooterSettings.Commands.UpdateRecruitFooterSetting;
using Settings.Application.Features.RecruitFooterSettings.Queries.GetAllRecruitFooterSettings;
using Settings.Application.Features.RecruitFooterSettings.Queries.GetRecruitFooterSettingById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RecruitFooterSettingController : ControllerBase
{
    private readonly IMediator _mediator;
    public RecruitFooterSettingController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var recruitFooterSettingList = await _mediator.Send(new GetAllRecruitFooterSettingsQuery());
        return Ok(recruitFooterSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var recruitFooterSetting = await _mediator.Send(new GetRecruitFooterSettingByIdQuery { Id = Id });
        if (recruitFooterSetting is not null) { return Ok(recruitFooterSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateRecruitFooterSettingCommand command)
    {
        await _mediator.Send(command);
        return Ok("RecruitFooterSetting Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateRecruitFooterSettingCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteRecruitFooterSettingCommand { Id = Id });
        return NoContent();
    }
}














