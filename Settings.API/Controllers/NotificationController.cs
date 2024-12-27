using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.Notifications.Commands.CreateNotification;
using Settings.Application.Features.Notifications.Commands.DeleteNotification;
using Settings.Application.Features.Notifications.Commands.UpdateNotification;
using Settings.Application.Features.Notifications.Queries.GetAllNotification;
using Settings.Application.Features.Notifications.Queries.GetByIdNotificaton;

namespace Settings.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class NotificationController : ControllerBase
{
    private readonly IMediator _mediator;
    public NotificationController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var notification = await _mediator.Send(new GetNotificationByIdQuery { Id = Id });
        if (notification is not null) { return Ok(notification); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateNotificationCommand command)
    {
        await _mediator.Send(command);
        return Ok("Notification Created Successfully.");
        //var product = await _mediator.Send(new GetNotificationByIdQuery { Id = Id });
        //if (product is not null) { return Ok(product); }
        //return NotFound();
    }


    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateNotificationCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _mediator.Send(new GetAllNotificationQuery());
        return Ok(consumerList);
    }


    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteNotificationCommand { Id = Id });
        return NoContent();
    }
}