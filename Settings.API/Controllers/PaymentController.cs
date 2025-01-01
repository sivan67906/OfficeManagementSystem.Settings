using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.Payments.Commands.CreatePayment;
using Settings.Application.Features.Payments.Commands.DeletePayment;
using Settings.Application.Features.Payments.Commands.UpdatePayment;
using Settings.Application.Features.Payments.Queries.GetAllPayment;
using Settings.Application.Features.Payments.Queries.GetPaymentById;

namespace Settings.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PaymentController : ControllerBase
{
    private readonly IMediator _mediator;
    public PaymentController(IMediator mediator) => _mediator = mediator;


    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var product = await _mediator.Send(new GetPaymentByIdQuery { Id = Id });
        if (product is not null) { return Ok(product); }
        return NotFound();
    }


    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreatePaymentCommand command)
    {
        var id = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, command);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdatePaymentCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _mediator.Send(new GetAllPaymentQuery());
        return Ok(consumerList);
    }


    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeletePaymentCommand { Id = Id });
        return NoContent();
    }
}
