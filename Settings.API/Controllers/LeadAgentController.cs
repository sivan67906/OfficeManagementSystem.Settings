using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Feauters.LeadAgent.Commands.CreateLeadAgent;
using Settings.Application.Feauters.LeadAgent.Commands.DeleteLeadAgent;
using Settings.Application.Feauters.LeadAgent.Commands.UpdateLeadAgent;
using Settings.Application.Feauters.LeadAgent.Queries.GetAllLeadAgents;
using Settings.Application.Feauters.LeadAgent.Queries.GetLeadAgentById;

namespace Settings.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadAgentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LeadAgentController(IMediator mediator) => _mediator = mediator;


        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int Id)
        {
            var product = await _mediator.Send(new GetLeadAgentsByIdQuery { Id = Id });
            if (product is not null) { return Ok(product); }
            return NotFound();
        }


        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateLeadAgentCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id }, command);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateLeadAgentCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var consumerList = await _mediator.Send(new GetAllLeadAgentsQuery());
            return Ok(consumerList);
        }


        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int Id)
        {
            await _mediator.Send(new DeleteLeadAgentCommand { Id = Id });
            return NoContent();
        }
    }
}
