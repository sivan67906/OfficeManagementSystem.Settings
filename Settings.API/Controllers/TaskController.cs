using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.Tasks.Commands.CreateTask;
using Settings.Application.Features.Tasks.Commands.DeleteTask;
using Settings.Application.Features.Tasks.Commands.UpdateTask;
using Settings.Application.Features.Tasks.Queries.GetAllTask;
using Settings.Application.Features.Tasks.Queries.GetTaskById;

namespace Settings.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    private readonly IMediator _mediator;
    public TaskController(IMediator mediator) => _mediator = mediator;


    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var product = await _mediator.Send(new GetTaskByIdQuery { Id = Id });
        if (product is not null) { return Ok(product); }
        return NotFound();
    }


    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateTaskCommand command)
    {
        var id = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, command);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateTaskCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _mediator.Send(new GetAllTaskQuery());
        return Ok(consumerList);
    }


    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteTaskCommand { Id = Id });
        return NoContent();
    }
}
