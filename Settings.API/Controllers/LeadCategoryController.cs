using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.DTOs;
using Settings.Application.Feauters.LeadCategory.Commands.CreateLeadCategory;

namespace Settings.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadCategoryController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LeadCategoryController(IMediator mediator) => _mediator = mediator;

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateLeadCategoryRequest leadCategory)
        {
            var result = await _mediator.Send(new CreateLeadCategoryCommand(leadCategory));
            return Ok(result);
        }

        //[HttpGet("GetById")]
        //public async Task<IActionResult> GetById(int Id)
        //{
        //    var product = await _mediator.Send(new GetLeadCategoryByIdQuery { Id = Id });
        //    if (product is not null) { return Ok(product); }
        //    return NotFound();
        //}


        //[HttpPost("Create")]
        //public async Task<IActionResult> Create(CreateLeadCategoryCommand command)
        //{
        //    var id = await _mediator.Send(command);
        //    return CreatedAtAction(nameof(GetById), new { id }, command);
        //}

        //[HttpPut("Update")]
        //public async Task<IActionResult> Update(UpdateLeadCategoryCommand command)
        //{
        //    await _mediator.Send(command);
        //    return NoContent();
        //}

        //[HttpGet("GetAll")]
        //public async Task<IActionResult> GetAll()
        //{
        //    var consumerList = await _mediator.Send(new GetAllLeadCategoryQuery());
        //    return Ok(consumerList);
        //}


        //[HttpDelete("Delete")]
        //public async Task<IActionResult> Delete(int Id)
        //{
        //    await _mediator.Send(new DeleteLeadCategoryCommand { Id = Id });
        //    return NoContent();
        //}
    }
}
