using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.RecruitGeneralSettings.Commands.CreateRecruitGeneralSetting;
using Settings.Application.Features.RecruitGeneralSettings.Commands.DeleteRecruitGeneralSetting;
using Settings.Application.Features.RecruitGeneralSettings.Commands.UpdateRecruitGeneralSetting;
using Settings.Application.Features.RecruitGeneralSettings.Queries.GetAllRecruitGeneralSettings;
using Settings.Application.Features.RecruitGeneralSettings.Queries.GetRecruitGeneralSettingById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RecruitGeneralSettingController : ControllerBase
{
    private readonly IMediator _mediator;
    public RecruitGeneralSettingController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var recruitGeneralSettingList = await _mediator.Send(new GetAllRecruitGeneralSettingsQuery());
        return Ok(recruitGeneralSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var recruitGeneralSetting = await _mediator.Send(new GetRecruitGeneralSettingByIdQuery { Id = Id });
        if (recruitGeneralSetting is not null) { return Ok(recruitGeneralSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateRecruitGeneralSettingCommand command)
    {
        await _mediator.Send(command);
        return Ok("RecruitGeneralSetting Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateRecruitGeneralSettingCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteRecruitGeneralSettingCommand { Id = Id });
        return NoContent();
    }
}














