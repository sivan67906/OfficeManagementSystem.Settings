using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.RecruitJobApplicationStatusSettings.Commands.CreateRecruitJobApplicationStatusSetting;
using Settings.Application.Features.RecruitJobApplicationStatusSettings.Commands.DeleteRecruitJobApplicationStatusSetting;
using Settings.Application.Features.RecruitJobApplicationStatusSettings.Commands.UpdateRecruitJobApplicationStatusSetting;
using Settings.Application.Features.RecruitJobApplicationStatusSettings.Queries.GetAllRecruitJobApplicationStatusSettings;
using Settings.Application.Features.RecruitJobApplicationStatusSettings.Queries.GetRecruitJobApplicationStatusSettingById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RecruitJobApplicationStatusSettingController : ControllerBase
{
    private readonly IMediator _mediator;
    public RecruitJobApplicationStatusSettingController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var recruitJobApplicationStatusSettingList = await _mediator.Send(new GetAllRecruitJobApplicationStatusSettingsQuery());
        return Ok(recruitJobApplicationStatusSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var recruitJobApplicationStatusSetting = await _mediator.Send(new GetRecruitJobApplicationStatusSettingByIdQuery { Id = Id });
        if (recruitJobApplicationStatusSetting is not null) { return Ok(recruitJobApplicationStatusSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateRecruitJobApplicationStatusSettingCommand command)
    {
        await _mediator.Send(command);
        return Ok("RecruitJobApplicationStatusSetting Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateRecruitJobApplicationStatusSettingCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteRecruitJobApplicationStatusSettingCommand { Id = Id });
        return NoContent();
    }
}










