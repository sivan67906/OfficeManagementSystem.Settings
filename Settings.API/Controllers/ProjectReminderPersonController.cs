using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.ProjectReminderPersons.Commands.CreateProjectReminderPerson;
using Settings.Application.Features.ProjectReminderPersons.Commands.DeleteProjectReminderPerson;
using Settings.Application.Features.ProjectReminderPersons.Commands.UpdateProjectReminderPerson;
using Settings.Application.Features.ProjectReminderPersons.Queries.GetAllProjectReminderPersons;
using Settings.Application.Features.ProjectReminderPersons.Queries.GetProjectReminderPersonById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectReminderPersonController : ControllerBase
{
    private readonly IMediator _mediator;
    public ProjectReminderPersonController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var projectReminderPersonList = await _mediator.Send(new GetAllProjectReminderPersonsQuery());
        return Ok(projectReminderPersonList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var projectReminderPerson = await _mediator.Send(new GetProjectReminderPersonByIdQuery { Id = Id });
        if (projectReminderPerson is not null) { return Ok(projectReminderPerson); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateProjectReminderPersonCommand command)
    {
        await _mediator.Send(command);
        return Ok("ProjectReminderPerson Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateProjectReminderPersonCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteProjectReminderPersonCommand { Id = Id });
        return NoContent();
    }
}














