using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.TimeLogs.Commands.CreateTimeLog;
using Settings.Application.Features.TimeLogs.Commands.DeleteTimeLog;
using Settings.Application.Features.TimeLogs.Commands.UpdateTimeLog;
using Settings.Application.Features.TimeLogs.Queries.GetAllTimeLogs;
using Settings.Application.Features.TimeLogs.Queries.GetTimeLogById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TimeLogController : ControllerBase
{
    private readonly IMediator _mediator;
    public TimeLogController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var timeLogList = await _mediator.Send(new GetAllTimeLogsQuery());
        return Ok(timeLogList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var timeLog = await _mediator.Send(new GetTimeLogByIdQuery { Id = Id });
        if (timeLog is not null) { return Ok(timeLog); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateTimeLogCommand command)
    {
        await _mediator.Send(command);
        return Ok("TimeLog Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateTimeLogCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteTimeLogCommand { Id = Id });
        return NoContent();
    }
}


















