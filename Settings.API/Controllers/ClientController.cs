using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.Cities.Commands.CreateCity;
using Settings.Application.Features.Client.Commands.CreateClient;
using Settings.Application.Features.Client.Commands.DeleteClient;
using Settings.Application.Features.Client.Commands.UpdateClient;
using Settings.Application.Features.Client.Queries.GetAllClients;
using Settings.Application.Features.Client.Queries.GetClientById;

namespace Settings.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ClientController : ControllerBase
{
    private readonly IMediator _mediator;
    public ClientController(IMediator mediator) => _mediator = mediator;


    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var product = await _mediator.Send(new GetClientByIdQuery { Id = Id });
        if (product is not null) { return Ok(product); }
        return NotFound();
    }


    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateClientCommand command)
    {
         await _mediator.Send(command);
        return Ok("Client Created Successfully.");
    }


    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateClientCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _mediator.Send(new GetAllClientsQuery());
        return Ok(consumerList);
    }


    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteClientCommand { Id = Id });
        return NoContent();
    }
}
