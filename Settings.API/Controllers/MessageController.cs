using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.Messages.Commands.CreateMessage;
using Settings.Application.Features.Messages.Commands.DeleteMessage;
using Settings.Application.Features.Messages.Commands.UpdateMessage;
using Settings.Application.Features.Messages.Queries.GetAllMessage;
using Settings.Application.Features.Messages.Queries.GetMessageById;

namespace Settings.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MessageController : ControllerBase
{
    private readonly IMediator _mediator;
    public MessageController(IMediator mediator) => _mediator = mediator;


    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var product = await _mediator.Send(new GetMessageByIdQuery { Id = Id });
        if (product is not null) { return Ok(product); }
        return NotFound();
    }


    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateMessageCommand command)
    {
        var id = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, command);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateMessageCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _mediator.Send(new GetAllMessageQuery());
        return Ok(consumerList);
    }


    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteMessageCommand { Id = Id });
        return NoContent();
    }
}
