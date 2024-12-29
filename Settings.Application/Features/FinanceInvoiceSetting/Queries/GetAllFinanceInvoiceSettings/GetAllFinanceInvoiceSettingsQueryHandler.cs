using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.FinanceInvoiceSettings.Queries.GetAllFinanceInvoiceSettings;

internal class GetAllFinanceInvoiceSettingsQueryHandler : IRequestHandler<GetAllFinanceInvoiceSettingsQuery, IEnumerable<FinanceInvoiceSettingDTO>>
{
    private readonly IGenericRepository<FinanceInvoiceSetting> _financeInvoiceSettingRepository;

    public GetAllFinanceInvoiceSettingsQueryHandler(
        IGenericRepository<FinanceInvoiceSetting> financeInvoiceSettingRepository)
    {
        _financeInvoiceSettingRepository = financeInvoiceSettingRepository;
    }

    public async Task<IEnumerable<FinanceInvoiceSettingDTO>> Handle(GetAllFinanceInvoiceSettingsQuery request, CancellationToken cancellationToken)
    {
        var financeInvoiceSettings = await _financeInvoiceSettingRepository.GetAllAsync();
        var financeInvoiceSettingList = financeInvoiceSettings.Select(x => new FinanceInvoiceSettingDTO
        {
            Id = x.Id,
            FILogoPath = x.FILogoPath,
            FILogoImageFileName = x.FILogoImageFileName,
            FIAuthorisedImagePath = x.FIAuthorisedImagePath,
            FIAuthorisedImageFileName = x.FIAuthorisedImageFileName,
            FILanguageId = x.FILanguageId,
            FIDueAfter = x.FIDueAfter,
            FISendReminderBefore = x.FISendReminderBefore,
            FISendReminderAfterEveryId = x.FISendReminderAfterEveryId,
            FISendReminderAfterEvery = x.FISendReminderAfterEvery,
            FICBGeneralJsonSettings = x.FICBGeneralJsonSettings,
            FICBClientInfoJsonSettings = x.FICBClientInfoJsonSettings,
            FITerms = x.FITerms,
            FIOtherInfo = x.FIOtherInfo
        }).ToList();

        return financeInvoiceSettingList;
    }
}












































