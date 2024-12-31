using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.TicketGroups.Commands.CreateTicketGroup;
using Settings.Application.Features.TicketGroups.Commands.DeleteTicketGroup;
using Settings.Application.Features.TicketGroups.Commands.UpdateTicketGroup;
using Settings.Application.Features.TicketGroups.Queries.GetAllTicketGroups;
using Settings.Application.Features.TicketGroups.Queries.GetTicketGroupById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TicketGroupController : ControllerBase
{
    private readonly IMediator _mediator;
    public TicketGroupController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var ticketGroupList = await _mediator.Send(new GetAllTicketGroupsQuery());
        return Ok(ticketGroupList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var ticketGroup = await _mediator.Send(new GetTicketGroupByIdQuery { Id = Id });
        if (ticketGroup is not null) { return Ok(ticketGroup); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateTicketGroupCommand command)
    {
        await _mediator.Send(command);
        return Ok("TicketGroup Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateTicketGroupCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteTicketGroupCommand { Id = Id });
        return NoContent();
    }
}






























