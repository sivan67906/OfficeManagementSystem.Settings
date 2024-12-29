using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.FinanceUnitSettings.Commands.CreateFinanceUnitSetting;

internal class CreateFinanceUnitSettingCommandHandler(
    IGenericRepository<FinanceUnitSetting> financeUnitSettingRepository) : IRequestHandler<CreateFinanceUnitSettingCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateFinanceUnitSettingCommand request, CancellationToken cancellationToken)
    {
        var financeUnitSetting = new FinanceUnitSetting
        {
            FUnitCode = request.FUnitCode,
            FUnitName = request.FUnitName,
            FIsDefault = request.FIsDefault,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await financeUnitSettingRepository.CreateAsync(financeUnitSetting);
    }
}
































