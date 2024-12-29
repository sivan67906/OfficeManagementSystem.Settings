using MediatR;

namespace Settings.Application.Features.FinanceUnitSettings.Commands.CreateFinanceUnitSetting;

public class CreateFinanceUnitSettingCommand : IRequest
{
    public string? FUnitCode { get; set; }
    public string? FUnitName { get; set; }
    public bool FIsDefault { get; set; }
}
































