using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.CustomQuestionCategories.Commands.CreateCustomQuestionCategory;
using Settings.Application.Features.CustomQuestionCategories.Commands.DeleteCustomQuestionCategory;
using Settings.Application.Features.CustomQuestionCategories.Commands.UpdateCustomQuestionCategory;
using Settings.Application.Features.CustomQuestionCategories.Queries.GetAllCustomQuestionCategories;
using Settings.Application.Features.CustomQuestionCategories.Queries.GetCustomQuestionCategoryById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomQuestionCategoryController : ControllerBase
{
    private readonly IMediator _mediator;
    public CustomQuestionCategoryController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var customQuestionCategoryList = await _mediator.Send(new GetAllCustomQuestionCategoriesQuery());
        return Ok(customQuestionCategoryList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var customQuestionCategory = await _mediator.Send(new GetCustomQuestionCategoryByIdQuery { Id = Id });
        if (customQuestionCategory is not null) { return Ok(customQuestionCategory); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateCustomQuestionCategoryCommand command)
    {
        await _mediator.Send(command);
        return Ok("CustomQuestionCategory Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateCustomQuestionCategoryCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteCustomQuestionCategoryCommand { Id = Id });
        return NoContent();
    }
}














