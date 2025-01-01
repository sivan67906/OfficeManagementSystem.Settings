﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.Employee.Commands.CreateEmployee;
using Settings.Application.Features.Employee.Commands.DeleteEmployee;
using Settings.Application.Features.Employee.Commands.UpdateEmployee;
using Settings.Application.Features.Employee.Queries.GetAllEmployee;
using Settings.Application.Features.Employee.Queries.GetEmployeeById;

namespace Settings.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{

    private readonly IMediator _mediator;
    public EmployeeController(IMediator mediator) => _mediator = mediator;


    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var product = await _mediator.Send(new GetEmployeeByIdQuery { Id = Id });
        if (product is not null) { return Ok(product); }
        return NotFound();
    }


    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateEmployeeCommand command)
    {
        await _mediator.Send(command);
        return Ok("Client Created Successfully.");
    }


    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateEmployeeCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _mediator.Send(new GetAllEmployeeQuery());
        return Ok(consumerList);
    }


    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteEmployeeCommand { Id = Id });
        return NoContent();
    }
}
