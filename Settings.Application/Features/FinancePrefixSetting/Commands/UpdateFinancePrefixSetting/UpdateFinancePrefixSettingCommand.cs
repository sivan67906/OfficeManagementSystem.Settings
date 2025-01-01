using MediatR;

namespace Settings.Application.Features.FinancePrefixSettings.Commands.UpdateFinancePrefixSetting;

public class UpdateFinancePrefixSettingCommand : IRequest
{
    public Guid Id { get; set; }
    public string? FICBPrefixJsonSettings { get; set; }
}




































