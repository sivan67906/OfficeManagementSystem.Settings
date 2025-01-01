using MediatR;

namespace Settings.Application.Features.FinancePrefixSettings.Commands.DeleteFinancePrefixSetting
{
    public class DeleteFinancePrefixSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}




































