using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.TicketAgents.Commands.CreateTicketAgent;
using Settings.Application.Features.TicketAgents.Commands.DeleteTicketAgent;
using Settings.Application.Features.TicketAgents.Commands.UpdateTicketAgent;
using Settings.Application.Features.TicketAgents.Queries.GetAllTicketAgents;
using Settings.Application.Features.TicketAgents.Queries.GetTicketAgentById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TicketAgentController : ControllerBase
{
    private readonly IMediator _mediator;
    public TicketAgentController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var ticketAgentList = await _mediator.Send(new GetAllTicketAgentsQuery());
        return Ok(ticketAgentList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var ticketAgent = await _mediator.Send(new GetTicketAgentByIdQuery { Id = Id });
        if (ticketAgent is not null) { return Ok(ticketAgent); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateTicketAgentCommand command)
    {
        await _mediator.Send(command);
        return Ok("TicketAgent Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateTicketAgentCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteTicketAgentCommand { Id = Id });
        return NoContent();
    }
}






























