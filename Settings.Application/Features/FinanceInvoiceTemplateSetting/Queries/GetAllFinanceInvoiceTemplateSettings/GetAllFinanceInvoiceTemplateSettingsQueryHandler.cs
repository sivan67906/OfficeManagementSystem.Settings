using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.FinanceInvoiceTemplateSettings.Queries.GetAllFinanceInvoiceTemplateSettings;

internal class GetAllFinanceInvoiceTemplateSettingsQueryHandler : IRequestHandler<GetAllFinanceInvoiceTemplateSettingsQuery, IEnumerable<FinanceInvoiceTemplateSettingDTO>>
{
    private readonly IGenericRepository<FinanceInvoiceTemplateSetting> _financeInvoiceTemplateSettingRepository;

    public GetAllFinanceInvoiceTemplateSettingsQueryHandler(
        IGenericRepository<FinanceInvoiceTemplateSetting> financeInvoiceTemplateSettingRepository)
    {
        _financeInvoiceTemplateSettingRepository = financeInvoiceTemplateSettingRepository;
    }

    public async Task<IEnumerable<FinanceInvoiceTemplateSettingDTO>> Handle(GetAllFinanceInvoiceTemplateSettingsQuery request, CancellationToken cancellationToken)
    {
        var financeInvoiceTemplateSettings = await _financeInvoiceTemplateSettingRepository.GetAllAsync();
        var financeInvoiceTemplateSettingList = financeInvoiceTemplateSettings.Select(x => new FinanceInvoiceTemplateSettingDTO
        {
            Id = x.Id,
            FIRBTemplateJsonSettings = x.FIRBTemplateJsonSettings
        }).ToList();

        return financeInvoiceTemplateSettingList;
    }
}








































