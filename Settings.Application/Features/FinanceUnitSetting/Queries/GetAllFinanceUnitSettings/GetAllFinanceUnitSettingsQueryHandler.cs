using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.FinanceUnitSettings.Queries.GetAllFinanceUnitSettings;

internal class GetAllFinanceUnitSettingsQueryHandler : IRequestHandler<GetAllFinanceUnitSettingsQuery, IEnumerable<FinanceUnitSettingDTO>>
{
    private readonly IGenericRepository<FinanceUnitSetting> _financeUnitSettingRepository;

    public GetAllFinanceUnitSettingsQueryHandler(
        IGenericRepository<FinanceUnitSetting> financeUnitSettingRepository)
    {
        _financeUnitSettingRepository = financeUnitSettingRepository;
    }

    public async Task<IEnumerable<FinanceUnitSettingDTO>> Handle(GetAllFinanceUnitSettingsQuery request, CancellationToken cancellationToken)
    {
        var financeUnitSettings = await _financeUnitSettingRepository.GetAllAsync();
        var financeUnitSettingList = financeUnitSettings.Select(x => new FinanceUnitSettingDTO
        {
            Id = x.Id,
            FUnitCode = x.FUnitCode,
            FUnitName = x.FUnitName,
            FIsDefault = x.FIsDefault
        }).ToList();

        return financeUnitSettingList;
    }
}
































