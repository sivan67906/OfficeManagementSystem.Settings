using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.Vendorcredits.Commands.CreateVendorcredit;
using Settings.Application.Features.Vendorcredits.Commands.DeleteVendorcredit;
using Settings.Application.Features.Vendorcredits.Commands.UpdateVendorcredit;
using Settings.Application.Features.Vendorcredits.Queries.GetAllVendorcredit;
using Settings.Application.Features.Vendorcredits.Queries.GetBillVendorcredit;

namespace Settings.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class VendorCreditController : ControllerBase
{
    private readonly IMediator _mediator;
    public VendorCreditController(IMediator mediator) => _mediator = mediator;


    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var product = await _mediator.Send(new GetVendorCreditByIdQuery { Id = Id });
        if (product is not null) { return Ok(product); }
        return NotFound();
    }


    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateVendorCreditCommand command)
    {
        var id = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, command);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateVendorCreditCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _mediator.Send(new GetAllVendorCreditQuery());
        return Ok(consumerList);
    }


    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteVendorCreditCommand { Id = Id });
        return NoContent();
    }
}
