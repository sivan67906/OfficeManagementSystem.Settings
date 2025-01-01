using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.ProjectCategories.Commands.CreateProjectCategory;
using Settings.Application.Features.ProjectCategories.Commands.DeleteProjectCategory;
using Settings.Application.Features.ProjectCategories.Commands.UpdateProjectCategory;
using Settings.Application.Features.ProjectCategories.Queries.GetAllProjectCategories;
using Settings.Application.Features.ProjectCategories.Queries.GetProjectCategoryById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectCategoryController : ControllerBase
{
    private readonly IMediator _mediator;
    public ProjectCategoryController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var projectCategoryList = await _mediator.Send(new GetAllProjectCategoriesQuery());
        return Ok(projectCategoryList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var projectCategory = await _mediator.Send(new GetProjectCategoryByIdQuery { Id = Id });
        if (projectCategory is not null) { return Ok(projectCategory); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateProjectCategoryCommand command)
    {
        await _mediator.Send(command);
        return Ok("ProjectCategory Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateProjectCategoryCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteProjectCategoryCommand { Id = Id });
        return NoContent();
    }
}


