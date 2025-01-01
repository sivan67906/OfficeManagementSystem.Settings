using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.Applications.Commands.CreateApplication;
using Settings.Application.Features.Applications.Commands.DeleteApplication;
using Settings.Application.Features.Applications.Commands.UpdateApplocation;
using Settings.Application.Features.Applications.Queries.GetAllApplications;
using Settings.Application.Features.Applications.Queries.GetApplicationById;

namespace Settings.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ApplicationController : ControllerBase
{
    private readonly IMediator _mediator;
    public ApplicationController(IMediator mediator) => _mediator = mediator;


    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var product = await _mediator.Send(new GetApplicationByIdQuery { Id = Id });
        if (product is not null) { return Ok(product); }
        return NotFound();
    }


    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateApplicationCommand command)
    {
        var id = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, command);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateApplicationCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _mediator.Send(new GetAllApplicationQuery());
        return Ok(consumerList);
    }


    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteApplicationCommand { Id = Id });
        return NoContent();
    }

}
