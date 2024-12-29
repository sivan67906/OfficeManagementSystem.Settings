using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.FinanceUnitSettings.Commands.CreateFinanceUnitSetting;
using Settings.Application.Features.FinanceUnitSettings.Commands.DeleteFinanceUnitSetting;
using Settings.Application.Features.FinanceUnitSettings.Commands.UpdateFinanceUnitSetting;
using Settings.Application.Features.FinanceUnitSettings.Queries.GetAllFinanceUnitSettings;
using Settings.Application.Features.FinanceUnitSettings.Queries.GetFinanceUnitSettingById;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FinanceUnitSettingController : ControllerBase
{
    private readonly IMediator _mediator;
    public FinanceUnitSettingController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var financeUnitSettingList = await _mediator.Send(new GetAllFinanceUnitSettingsQuery());
        return Ok(financeUnitSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var financeUnitSetting = await _mediator.Send(new GetFinanceUnitSettingByIdQuery { Id = Id });
        if (financeUnitSetting is not null) { return Ok(financeUnitSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateFinanceUnitSettingCommand command)
    {
        await _mediator.Send(command);
        return Ok("FinanceUnitSetting Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateFinanceUnitSettingCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteFinanceUnitSettingCommand { Id = Id });
        return NoContent();
    }
}






















