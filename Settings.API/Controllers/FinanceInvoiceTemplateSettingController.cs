using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.FinanceInvoiceTemplateSettings.Commands.CreateFinanceInvoiceTemplateSetting;
using Settings.Application.Features.FinanceInvoiceTemplateSettings.Commands.DeleteFinanceInvoiceTemplateSetting;
using Settings.Application.Features.FinanceInvoiceTemplateSettings.Commands.UpdateFinanceInvoiceTemplateSetting;
using Settings.Application.Features.FinanceInvoiceTemplateSettings.Queries.GetAllFinanceInvoiceTemplateSettings;
using Settings.Application.Features.FinanceInvoiceTemplateSettings.Queries.GetFinanceInvoiceTemplateSettingById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FinanceInvoiceTemplateSettingController : ControllerBase
{
    private readonly IMediator _mediator;
    public FinanceInvoiceTemplateSettingController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var financeInvoiceTemplateSettingList = await _mediator.Send(new GetAllFinanceInvoiceTemplateSettingsQuery());
        return Ok(financeInvoiceTemplateSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var financeInvoiceTemplateSetting = await _mediator.Send(new GetFinanceInvoiceTemplateSettingByIdQuery { Id = Id });
        if (financeInvoiceTemplateSetting is not null) { return Ok(financeInvoiceTemplateSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateFinanceInvoiceTemplateSettingCommand command)
    {
        await _mediator.Send(command);
        return Ok("FinanceInvoiceTemplateSetting Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateFinanceInvoiceTemplateSettingCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteFinanceInvoiceTemplateSettingCommand { Id = Id });
        return NoContent();
    }
}






























