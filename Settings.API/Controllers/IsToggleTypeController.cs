using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.IsToggleTypes.Commands.CreateIsToggleType;
using Settings.Application.Features.IsToggleTypes.Commands.DeleteIsToggleType;
using Settings.Application.Features.IsToggleTypes.Commands.UpdateIsToggleType;
using Settings.Application.Features.IsToggleTypes.Queries.GetAllIsToggleTypes;
using Settings.Application.Features.IsToggleTypes.Queries.GetIsToggleTypeById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class IsToggleTypeController : ControllerBase
{
    private readonly IMediator _mediator;
    public IsToggleTypeController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var isToggleTypeList = await _mediator.Send(new GetAllIsToggleTypesQuery());
        return Ok(isToggleTypeList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var isToggleType = await _mediator.Send(new GetIsToggleTypeByIdQuery { Id = Id });
        if (isToggleType is not null) { return Ok(isToggleType); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateIsToggleTypeCommand command)
    {
        await _mediator.Send(command);
        return Ok("IsToggleType Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateIsToggleTypeCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteIsToggleTypeCommand { Id = Id });
        return NoContent();
    }
}


















