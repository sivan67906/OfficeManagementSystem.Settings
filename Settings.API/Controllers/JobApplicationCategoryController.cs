using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.JobApplicationCategories.Commands.CreateJobApplicationCategory;
using Settings.Application.Features.JobApplicationCategories.Commands.DeleteJobApplicationCategory;
using Settings.Application.Features.JobApplicationCategories.Commands.UpdateJobApplicationCategory;
using Settings.Application.Features.JobApplicationCategories.Queries.GetAllJobApplicationCategories;
using Settings.Application.Features.JobApplicationCategories.Queries.GetJobApplicationCategoryById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class JobApplicationCategoryController : ControllerBase
{
    private readonly IMediator _mediator;
    public JobApplicationCategoryController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var jobApplicationCategoryList = await _mediator.Send(new GetAllJobApplicationCategoriesQuery());
        return Ok(jobApplicationCategoryList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var jobApplicationCategory = await _mediator.Send(new GetJobApplicationCategoryByIdQuery { Id = Id });
        if (jobApplicationCategory is not null) { return Ok(jobApplicationCategory); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateJobApplicationCategoryCommand command)
    {
        await _mediator.Send(command);
        return Ok("JobApplicationCategory Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateJobApplicationCategoryCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteJobApplicationCategoryCommand { Id = Id });
        return NoContent();
    }
}














