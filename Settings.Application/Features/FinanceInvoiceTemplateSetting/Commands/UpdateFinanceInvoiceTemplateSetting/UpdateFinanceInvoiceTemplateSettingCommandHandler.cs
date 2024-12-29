using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.FinanceInvoiceTemplateSettings.Commands.UpdateFinanceInvoiceTemplateSetting;

internal class UpdateFinanceInvoiceTemplateSettingCommandHandler : IRequestHandler<UpdateFinanceInvoiceTemplateSettingCommand>
{
    private readonly IGenericRepository<FinanceInvoiceTemplateSetting> _financeInvoiceTemplateSettingRepository;

    public UpdateFinanceInvoiceTemplateSettingCommandHandler(
        IGenericRepository<FinanceInvoiceTemplateSetting> financeInvoiceTemplateSettingRepository) =>
        _financeInvoiceTemplateSettingRepository = financeInvoiceTemplateSettingRepository;

    public async System.Threading.Tasks.Task Handle(UpdateFinanceInvoiceTemplateSettingCommand request, CancellationToken cancellationToken)
    {
        var financeInvoiceTemplateSetting = new FinanceInvoiceTemplateSetting
        {
            Id = request.Id,
            FIRBTemplateJsonSettings = request.FIRBTemplateJsonSettings,
            UpdatedDate = DateTime.Now
        };

        await _financeInvoiceTemplateSettingRepository.UpdateAsync(financeInvoiceTemplateSetting);
    }
}








































