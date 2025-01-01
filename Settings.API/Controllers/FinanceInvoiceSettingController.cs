using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.FinanceInvoiceSettings.Commands.CreateFinanceInvoiceSetting;
using Settings.Application.Features.FinanceInvoiceSettings.Commands.DeleteFinanceInvoiceSetting;
using Settings.Application.Features.FinanceInvoiceSettings.Commands.UpdateFinanceInvoiceSetting;
using Settings.Application.Features.FinanceInvoiceSettings.Queries.GetAllFinanceInvoiceSettings;
using Settings.Application.Features.FinanceInvoiceSettings.Queries.GetFinanceInvoiceSettingById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FinanceInvoiceSettingController : ControllerBase
{
    private readonly IMediator _mediator;
    public FinanceInvoiceSettingController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var financeInvoiceSettingList = await _mediator.Send(new GetAllFinanceInvoiceSettingsQuery());
        return Ok(financeInvoiceSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var financeInvoiceSetting = await _mediator.Send(new GetFinanceInvoiceSettingByIdQuery { Id = Id });
        if (financeInvoiceSetting is not null) { return Ok(financeInvoiceSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateFinanceInvoiceSettingCommand command)
    {
        await _mediator.Send(command);
        return Ok("FinanceInvoiceSetting Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateFinanceInvoiceSettingCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteFinanceInvoiceSettingCommand { Id = Id });
        return NoContent();
    }
}


































