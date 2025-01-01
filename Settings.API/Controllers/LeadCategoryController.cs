﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.DTOs.Lead;
using Settings.Application.DTOs.LeadCategory;
using Settings.Application.Feauters.LeadCategory.Commands.CreateLeadCategory;
using Settings.Application.Feauters.LeadCategory.Commands.DeleteLeadCategory;
using Settings.Application.Feauters.LeadCategory.Commands.UpdateLeadCategory;
using Settings.Application.Feauters.LeadCategory.Queries.GetAllLeadCategories;
using Settings.Application.Feauters.LeadCategory.Queries.GetLeadCategoryById;

namespace Settings.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadCategoryController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LeadCategoryController(IMediator mediator) => _mediator = mediator;

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(GetLeadCategory leadCategory)
        {
            var result = await _mediator.Send(new GetLeadCategoryByIdQuery(leadCategory.Id));
            return Ok(result);
        }


        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateLeadCategoryRequest leadCategory)
        {
            var result = await _mediator.Send(new CreateLeadCategoryCommand(leadCategory));
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateLeadCategoryRequest leadCategory)
        {
            await _mediator.Send(new UpdateLeadCategoryCommand(leadCategory));
            return NoContent();
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var consumerList = await _mediator.Send(new GetAllLeadCategoryQuery());
            return Ok(consumerList);
        }


        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(Guid Id)
        {
            await _mediator.Send(new DeleteLeadCategoryCommand(Id));
            return NoContent();
        }
    }
}
