using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.ProjectStatus.Commands.UpdateProjectStatusDefault;
using Settings.Application.Features.ProjectStatuses.Commands.CreateProjectStatus;
using Settings.Application.Features.ProjectStatuses.Commands.DeleteProjectStatus;
using Settings.Application.Features.ProjectStatuses.Commands.UpdateProjectStatus;
using Settings.Application.Features.ProjectStatuses.Queries.GetAllProjectStatuses;
using Settings.Application.Features.ProjectStatuses.Queries.GetProjectStatusById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectStatusController : ControllerBase
{
    private readonly IMediator _mediator;
    public ProjectStatusController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var projectStatusList = await _mediator.Send(new GetAllProjectStatusesQuery());
        return Ok(projectStatusList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var projectStatus = await _mediator.Send(new GetProjectStatusByIdQuery { Id = Id });
        if (projectStatus is not null) { return Ok(projectStatus); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateProjectStatusCommand command)
    {
        await _mediator.Send(command);
        return Ok("ProjectStatus Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateProjectStatusCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpPut("UpdateDefaultStatus")]
    public async Task<IActionResult> Update1(UpdateProjectStatusDefaultCommand command)
    {
        //var projectStatus = await _mediator.Send(new GetProjectStatusByIdQuery { Id = command.Id });

        //if (projectStatus is null) return NoContent();
        //projectStatus.Id = command.Id;

        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteProjectStatusCommand { Id = Id });
        return NoContent();
    }
}






