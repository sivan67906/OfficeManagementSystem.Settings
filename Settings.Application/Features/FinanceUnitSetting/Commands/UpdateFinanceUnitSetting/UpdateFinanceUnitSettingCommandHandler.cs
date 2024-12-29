using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.FinanceUnitSettings.Commands.UpdateFinanceUnitSetting;

internal class UpdateFinanceUnitSettingCommandHandler : IRequestHandler<UpdateFinanceUnitSettingCommand>
{
    private readonly IGenericRepository<FinanceUnitSetting> _financeUnitSettingRepository;

    public UpdateFinanceUnitSettingCommandHandler(
        IGenericRepository<FinanceUnitSetting> financeUnitSettingRepository) =>
        _financeUnitSettingRepository = financeUnitSettingRepository;

    public async System.Threading.Tasks.Task Handle(UpdateFinanceUnitSettingCommand request, CancellationToken cancellationToken)
    {
        var financeUnitSetting = new FinanceUnitSetting
        {
            Id = request.Id,
            FUnitCode = request.FUnitCode,
            FUnitName = request.FUnitName,
            FIsDefault = request.FIsDefault,
            UpdatedDate = DateTime.Now
        };

        await _financeUnitSettingRepository.UpdateAsync(financeUnitSetting);
    }
}
































