using MediatR;

namespace Settings.Application.Features.FinancePrefixSettings.Commands.CreateFinancePrefixSetting;

public class CreateFinancePrefixSettingCommand : IRequest
{
    public string? FICBPrefixJsonSettings { get; set; }
}




































