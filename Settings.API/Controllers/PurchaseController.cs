using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.Purchases.Commands.CreatePurchase;
using Settings.Application.Features.Purchases.Commands.DeletePurchase;
using Settings.Application.Features.Purchases.Commands.UpdatePurchase;
using Settings.Application.Features.Purchases.Queries.GetAllPurchase;
using Settings.Application.Features.Purchases.Queries.GetByIdPurchase;

namespace Settings.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PurchaseController : ControllerBase
{
    private readonly IMediator _mediator;
    public PurchaseController(IMediator mediator) => _mediator = mediator;


    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var product = await _mediator.Send(new GetPurchaseByIdQuery { Id = Id });
        if (product is not null) { return Ok(product); }
        return NotFound();
    }


    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreatePurchaseCommand command)
    {
        var id = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, command);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdatePurchaseCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _mediator.Send(new GetAllPurchaseQuery());
        return Ok(consumerList);
    }


    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeletePurchaseCommand { Id = Id });
        return NoContent();
    }
}
