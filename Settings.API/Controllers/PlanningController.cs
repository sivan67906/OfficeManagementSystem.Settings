using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.Plannings.Commands.CreatePlanning;
using Settings.Application.Features.Plannings.Commands.DeletePlanning;
using Settings.Application.Features.Plannings.Commands.UpdatePlanning;
using Settings.Application.Features.Plannings.Queries.GetAllPlannings;
using Settings.Application.Features.Plannings.Queries.GetPlanningById;

namespace Settings.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PlanningController : ControllerBase
{
    private readonly IMediator _mediator;
    public PlanningController(IMediator mediator) => _mediator = mediator;


    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var product = await _mediator.Send(new GetPlanningByIdQuery { Id = Id });
        if (product is not null) { return Ok(product); }
        return NotFound();
    }


    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreatePlanningCommand command)
    {
        var id = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, command);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdatePlanningCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _mediator.Send(new GetAllPlanningsQuery());
        return Ok(consumerList);
    }


    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeletePlanningCommand { Id = Id });
        return NoContent();
    }
}
