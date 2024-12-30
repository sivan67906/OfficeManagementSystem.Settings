using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.TicketChannels.Commands.CreateTicketChannel;
using Settings.Application.Features.TicketChannels.Commands.DeleteTicketChannel;
using Settings.Application.Features.TicketChannels.Commands.UpdateTicketChannel;
using Settings.Application.Features.TicketChannels.Queries.GetAllTicketChannels;
using Settings.Application.Features.TicketChannels.Queries.GetTicketChannelById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TicketChannelController : ControllerBase
{
    private readonly IMediator _mediator;
    public TicketChannelController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var ticketChannelList = await _mediator.Send(new GetAllTicketChannelsQuery());
        return Ok(ticketChannelList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var ticketChannel = await _mediator.Send(new GetTicketChannelByIdQuery { Id = Id });
        if (ticketChannel is not null) { return Ok(ticketChannel); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateTicketChannelCommand command)
    {
        await _mediator.Send(command);
        return Ok("TicketChannel Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateTicketChannelCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteTicketChannelCommand { Id = Id });
        return NoContent();
    }
}






























