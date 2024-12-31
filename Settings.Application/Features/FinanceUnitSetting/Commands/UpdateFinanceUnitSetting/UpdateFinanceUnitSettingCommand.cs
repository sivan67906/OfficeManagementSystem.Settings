using MediatR;

namespace Settings.Application.Features.FinanceUnitSettings.Commands.UpdateFinanceUnitSetting;

public class UpdateFinanceUnitSettingCommand : IRequest
{
    public int Id { get; set; }
    public string? FUnitCode { get; set; }
    public string? FUnitName { get; set; }
    public bool FIsDefault { get; set; }
}
































