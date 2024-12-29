using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.FinanceInvoiceTemplateSettings.Commands.CreateFinanceInvoiceTemplateSetting;

internal class CreateFinanceInvoiceTemplateSettingCommandHandler(
    IGenericRepository<FinanceInvoiceTemplateSetting> financeInvoiceTemplateSettingRepository) : IRequestHandler<CreateFinanceInvoiceTemplateSettingCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateFinanceInvoiceTemplateSettingCommand request, CancellationToken cancellationToken)
    {
        var financeInvoiceTemplateSetting = new FinanceInvoiceTemplateSetting
        {
            FIRBTemplateJsonSettings = request.FIRBTemplateJsonSettings,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await financeInvoiceTemplateSettingRepository.CreateAsync(financeInvoiceTemplateSetting);
    }
}








































