using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.FinancePrefixSettings.Commands.CreateFinancePrefixSetting;

internal class CreateFinancePrefixSettingCommandHandler(
    IGenericRepository<FinancePrefixSetting> financeInvoiceTemplateSettingRepository) : IRequestHandler<CreateFinancePrefixSettingCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateFinancePrefixSettingCommand request, CancellationToken cancellationToken)
    {
        var financeInvoiceTemplateSetting = new FinancePrefixSetting
        {
            FICBPrefixJsonSettings = request.FICBPrefixJsonSettings,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await financeInvoiceTemplateSettingRepository.CreateAsync(financeInvoiceTemplateSetting);
    }
}




































