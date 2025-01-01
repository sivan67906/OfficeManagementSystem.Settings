using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.Departments.Commands.CreateDepartment;
using Settings.Application.Features.Departments.Commands.DeleteDepartment;
using Settings.Application.Features.Departments.Commands.UpdateDepartment;
using Settings.Application.Features.Departments.Queries.GetAllDepartments;
using Settings.Application.Features.Departments.Queries.GetDepartmentById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartmentController : ControllerBase
{
    private readonly IMediator _mediator;
    public DepartmentController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var departmentList = await _mediator.Send(new GetAllDepartmentsQuery());
        return Ok(departmentList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var department = await _mediator.Send(new GetDepartmentByIdQuery { Id = Id });
        if (department is null) return NotFound();
        return Ok(department);
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateDepartmentCommand command)
    {
        await _mediator.Send(command);
        return Ok("Department Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateDepartmentCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteDepartmentCommand { Id = Id });
        return NoContent();
    }
}


