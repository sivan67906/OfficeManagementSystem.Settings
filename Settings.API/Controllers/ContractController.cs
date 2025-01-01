using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.Contracts.Commands.CreateContract;
using Settings.Application.Features.Contracts.Commands.DeleteContract;
using Settings.Application.Features.Contracts.Commands.UpdateContract;
using Settings.Application.Features.Contracts.Queries.GetAllContract;
using Settings.Application.Features.Contracts.Queries.GetContractById;

namespace Settings.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ContractController : ControllerBase
{
    private readonly IMediator _mediator;
    public ContractController(IMediator mediator) => _mediator = mediator;


    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var product = await _mediator.Send(new GetContractByIdQuery { Id = Id });
        if (product is not null) { return Ok(product); }
        return NotFound();
    }


    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateContractCommand command)
    {
        var id = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, command);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateContractCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _mediator.Send(new GetAllContractQuery());
        return Ok(consumerList);
    }


    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteContractCommand { Id = Id });
        return NoContent();
    }
}
