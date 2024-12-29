using MediatR;

namespace Settings.Application.Features.FinancePrefixSettings.Commands.DeleteFinancePrefixSetting
{
    public class DeleteFinancePrefixSettingCommand : IRequest
    {
        public int Id { get; set; }
    }
}




































