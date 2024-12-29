using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.FinanceInvoiceSettings.Queries.GetFinanceInvoiceSettingById;

internal class GetFinanceInvoiceSettingByIdQueryHandler : IRequestHandler<GetFinanceInvoiceSettingByIdQuery, FinanceInvoiceSettingDTO>
{
    private readonly IGenericRepository<FinanceInvoiceSetting> _financeInvoiceSettingRepository;

    public GetFinanceInvoiceSettingByIdQueryHandler(
        IGenericRepository<FinanceInvoiceSetting> financeInvoiceSettingRepository) =>
        _financeInvoiceSettingRepository = financeInvoiceSettingRepository;

    public async Task<FinanceInvoiceSettingDTO> Handle(GetFinanceInvoiceSettingByIdQuery request, CancellationToken cancellationToken)
    {
        var financeInvoiceSetting = await _financeInvoiceSettingRepository.GetByIdAsync(request.Id);
        if (financeInvoiceSetting == null) return null;
        return new FinanceInvoiceSettingDTO
        {
            Id = financeInvoiceSetting.Id,
            FILogoPath = financeInvoiceSetting.FILogoPath,
            FILogoImageFileName = financeInvoiceSetting.FILogoImageFileName,
            FIAuthorisedImagePath = financeInvoiceSetting.FIAuthorisedImagePath,
            FIAuthorisedImageFileName = financeInvoiceSetting.FIAuthorisedImageFileName,
            FILanguageId = financeInvoiceSetting.FILanguageId,
            FIDueAfter = financeInvoiceSetting.FIDueAfter,
            FISendReminderBefore = financeInvoiceSetting.FISendReminderBefore,
            FISendReminderAfterEveryId = financeInvoiceSetting.FISendReminderAfterEveryId,
            FISendReminderAfterEvery = financeInvoiceSetting.FISendReminderAfterEvery,
            FICBGeneralJsonSettings = financeInvoiceSetting.FICBGeneralJsonSettings,
            FICBClientInfoJsonSettings = financeInvoiceSetting.FICBClientInfoJsonSettings,
            FITerms = financeInvoiceSetting.FITerms,
            FIOtherInfo = financeInvoiceSetting.FIOtherInfo
        };
    }
}












































