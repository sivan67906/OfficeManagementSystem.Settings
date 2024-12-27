using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.Notifications.Commands.CreateNotification;
using Settings.Application.Features.Notifications.Commands.DeleteNotification;
using Settings.Application.Features.Notifications.Commands.UpdateNotification;
using Settings.Application.Features.Notifications.Queries.GetAllNotifications;
using Settings.Application.Features.Notifications.Queries.GetNotificationById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NotificationController : ControllerBase
{
    private readonly IMediator _mediator;
    public NotificationController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var notificationList = await _mediator.Send(new GetAllNotificationsQuery());
        return Ok(notificationList);
    }

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
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateNotificationCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteNotificationCommand { Id = Id });
        return NoContent();
    }
}



















