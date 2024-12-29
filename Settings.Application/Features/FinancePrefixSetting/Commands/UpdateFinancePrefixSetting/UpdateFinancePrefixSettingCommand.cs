using MediatR;

namespace Settings.Application.Features.FinancePrefixSettings.Commands.UpdateFinancePrefixSetting;

public class UpdateFinancePrefixSettingCommand : IRequest
{
    public int Id { get; set; }
    public string? FICBPrefixJsonSettings { get; set; }
}




































