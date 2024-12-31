using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.AttendanceSettings.Commands.CreateAttendanceSetting;
using Settings.Application.Features.AttendanceSettings.Commands.DeleteAttendanceSetting;
using Settings.Application.Features.AttendanceSettings.Commands.UpdateAttendanceSetting;
using Settings.Application.Features.AttendanceSettings.Queries.GetAllAttendanceSettings;
using Settings.Application.Features.AttendanceSettings.Queries.GetAttendanceSettingById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AttendanceSettingController : ControllerBase
{
    private readonly IMediator _mediator;
    public AttendanceSettingController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var attendanceSettingList = await _mediator.Send(new GetAllAttendanceSettingsQuery());
        return Ok(attendanceSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var attendanceSetting = await _mediator.Send(new GetAttendanceSettingByIdQuery { Id = Id });
        if (attendanceSetting is not null) { return Ok(attendanceSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateAttendanceSettingCommand command)
    {
        await _mediator.Send(command);
        return Ok("AttendanceSetting Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateAttendanceSettingCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteAttendanceSettingCommand { Id = Id });
        return NoContent();
    }
}






























