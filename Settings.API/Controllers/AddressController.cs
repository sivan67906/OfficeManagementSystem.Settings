using Settings.Application.Features.Addresses.Commands.CreateAddress;
using Settings.Application.Features.Addresses.Commands.DeleteAddress;
using Settings.Application.Features.Addresses.Commands.UpdateAddress;
using Settings.Application.Features.Addresses.Queries.GetAddressById;
using Settings.Application.Features.Addresses.Queries.GetAllAddresses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AddressController : ControllerBase
{
    private readonly IMediator _mediator;
    public AddressController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var addressList = await _mediator.Send(new GetAllAddressesQuery());
        return Ok(addressList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var address = await _mediator.Send(new GetAddressByIdQuery { Id = Id });
        if (address is not null) { return Ok(address); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateAddressCommand command)
    {
        await _mediator.Send(command);
        return Ok("Address Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateAddressCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteAddressCommand { Id = Id });
        return NoContent();
    }
}

