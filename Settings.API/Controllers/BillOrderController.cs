using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.BillOrders.Commands.CreateBillOrder;
using Settings.Application.Features.BillOrders.Commands.DeleteBillOrder;
using Settings.Application.Features.BillOrders.Commands.UpdateBillOrder;
using Settings.Application.Features.BillOrders.Queries.GetAllBillOrder;
using Settings.Application.Features.BillOrders.Queries.GetBillOrderById;
using Settings.Application.Features.Taxes.Commands.CreateTax;
using Settings.Application.Features.Taxes.Commands.DeleteTax;
using Settings.Application.Features.Taxes.Commands.UpdateTax;
using Settings.Application.Features.Taxes.Queries.GetAllTax;
using Settings.Application.Features.Taxes.Queries.GetTaxById;

namespace Settings.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BillOrderController : ControllerBase
{
    private readonly IMediator _mediator;
    public BillOrderController(IMediator mediator) => _mediator = mediator;


    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var product = await _mediator.Send(new GetBillOrderByIdQuery { Id = Id });
        if (product is not null) { return Ok(product); }
        return NotFound();
    }


    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateBillOrderCommand command)
    {
        var id = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, command);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateBillOrderCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _mediator.Send(new GetAllBillOrderQuery());
        return Ok(consumerList);
    }


    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteBillOrderCommand { Id = Id });
        return NoContent();
    }
}
