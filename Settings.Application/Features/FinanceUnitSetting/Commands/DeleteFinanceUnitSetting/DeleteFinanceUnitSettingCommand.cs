using MediatR;

namespace Settings.Application.Features.FinanceUnitSettings.Commands.DeleteFinanceUnitSetting
{
    public class DeleteFinanceUnitSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
































