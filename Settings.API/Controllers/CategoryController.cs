using Settings.Application.Features.Categories.Commands.CreateCategory;
using Settings.Application.Features.Categories.Commands.DeleteCategory;
using Settings.Application.Features.Categories.Commands.UpdateCategory;
using Settings.Application.Features.Categories.Queries.GetAllCategories;
using Settings.Application.Features.Categories.Queries.GetCategoryById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly IMediator _mediator;
    public CategoryController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var categoryList = await _mediator.Send(new GetAllCategoriesQuery());
        return Ok(categoryList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var category = await _mediator.Send(new GetCategoryByIdQuery { Id = Id });
        if (category is not null) { return Ok(category); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateCategoryCommand command)
    {
        await _mediator.Send(command);
        return Ok("Category Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateCategoryCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteCategoryCommand { Id = Id });
        return NoContent();
    }
}



