using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.JobApplicationPositions.Commands.CreateJobApplicationPosition;
using Settings.Application.Features.JobApplicationPositions.Commands.DeleteJobApplicationPosition;
using Settings.Application.Features.JobApplicationPositions.Commands.UpdateJobApplicationPosition;
using Settings.Application.Features.JobApplicationPositions.Queries.GetAllJobApplicationPositions;
using Settings.Application.Features.JobApplicationPositions.Queries.GetJobApplicationPositionById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class JobApplicationPositionController : ControllerBase
{
    private readonly IMediator _mediator;
    public JobApplicationPositionController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var jobApplicationPositionList = await _mediator.Send(new GetAllJobApplicationPositionsQuery());
        return Ok(jobApplicationPositionList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var jobApplicationPosition = await _mediator.Send(new GetJobApplicationPositionByIdQuery { Id = Id });
        if (jobApplicationPosition is not null) { return Ok(jobApplicationPosition); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateJobApplicationPositionCommand command)
    {
        await _mediator.Send(command);
        return Ok("JobApplicationPosition Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateJobApplicationPositionCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteJobApplicationPositionCommand { Id = Id });
        return NoContent();
    }
}














