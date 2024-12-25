using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.Notifications.Commands.CreateNotification;
using Settings.Application.Features.Notifications.Commands.DeleteNotification;
using Settings.Application.Features.Notifications.Commands.UpdateNotification;
using Settings.Application.Features.Notifications.Queries.GetAllNotification;
using Settings.Application.Features.Notifications.Queries.GetByIdNotificaton;
using Settings.Application.Features.Taxes.Commands.CreateTax;
using Settings.Application.Features.Taxes.Commands.DeleteTax;
using Settings.Application.Features.Taxes.Commands.UpdateTax;
using Settings.Application.Features.Taxes.Queries.GetAllTax;
using Settings.Application.Features.Taxes.Queries.GetTaxById;

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
        var product = await _mediator.Send(new GetNotificationByIdQuery { Id = Id });
        if (product is not null) { return Ok(product); }
        return NotFound();
    }


    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateNotificationCommand command)
    {
        var id = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, command);
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
