using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.CustomQuestionTypes.Commands.CreateCustomQuestionType;
using Settings.Application.Features.CustomQuestionTypes.Commands.DeleteCustomQuestionType;
using Settings.Application.Features.CustomQuestionTypes.Commands.UpdateCustomQuestionType;
using Settings.Application.Features.CustomQuestionTypes.Queries.GetAllCustomQuestionTypes;
using Settings.Application.Features.CustomQuestionTypes.Queries.GetCustomQuestionTypeById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomQuestionTypeController : ControllerBase
{
    private readonly IMediator _mediator;
    public CustomQuestionTypeController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var customQuestionTypeList = await _mediator.Send(new GetAllCustomQuestionTypesQuery());
        return Ok(customQuestionTypeList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var customQuestionType = await _mediator.Send(new GetCustomQuestionTypeByIdQuery { Id = Id });
        if (customQuestionType is not null) { return Ok(customQuestionType); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateCustomQuestionTypeCommand command)
    {
        await _mediator.Send(command);
        return Ok("CustomQuestionType Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateCustomQuestionTypeCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteCustomQuestionTypeCommand { Id = Id });
        return NoContent();
    }
}














