using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.FinancePrefixSettings.Commands.CreateFinancePrefixSetting;
using Settings.Application.Features.FinancePrefixSettings.Commands.DeleteFinancePrefixSetting;
using Settings.Application.Features.FinancePrefixSettings.Commands.UpdateFinancePrefixSetting;
using Settings.Application.Features.FinancePrefixSettings.Queries.GetAllFinancePrefixSettings;
using Settings.Application.Features.FinancePrefixSettings.Queries.GetFinancePrefixSettingById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FinancePrefixSettingController : ControllerBase
{
    private readonly IMediator _mediator;
    public FinancePrefixSettingController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var financeInvoiceTemplateSettingList = await _mediator.Send(new GetAllFinancePrefixSettingsQuery());
        return Ok(financeInvoiceTemplateSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var financeInvoiceTemplateSetting = await _mediator.Send(new GetFinancePrefixSettingByIdQuery { Id = Id });
        if (financeInvoiceTemplateSetting is not null) { return Ok(financeInvoiceTemplateSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateFinancePrefixSettingCommand command)
    {
        await _mediator.Send(command);
        return Ok("FinancePrefixSetting Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateFinancePrefixSettingCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteFinancePrefixSettingCommand { Id = Id });
        return NoContent();
    }
}


























