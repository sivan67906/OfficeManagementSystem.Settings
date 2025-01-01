using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.RecruiterSettings.Commands.CreateRecruiterSetting;
using Settings.Application.Features.RecruiterSettings.Commands.DeleteRecruiterSetting;
using Settings.Application.Features.RecruiterSettings.Commands.UpdateRecruiterSetting;
using Settings.Application.Features.RecruiterSettings.Queries.GetAllRecruiterSettings;
using Settings.Application.Features.RecruiterSettings.Queries.GetRecruiterSettingById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RecruiterSettingController : ControllerBase
{
    private readonly IMediator _mediator;
    public RecruiterSettingController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var recruiterSettingList = await _mediator.Send(new GetAllRecruiterSettingsQuery());
        return Ok(recruiterSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var recruiterSetting = await _mediator.Send(new GetRecruiterSettingByIdQuery { Id = Id });
        if (recruiterSetting is not null) { return Ok(recruiterSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateRecruiterSettingCommand command)
    {
        await _mediator.Send(command);
        return Ok("RecruiterSetting Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateRecruiterSettingCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteRecruiterSettingCommand { Id = Id });
        return NoContent();
    }
}










