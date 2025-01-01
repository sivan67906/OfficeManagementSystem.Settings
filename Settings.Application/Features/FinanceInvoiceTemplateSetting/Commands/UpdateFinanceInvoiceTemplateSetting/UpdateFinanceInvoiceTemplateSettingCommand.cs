using MediatR;

namespace Settings.Application.Features.FinanceInvoiceTemplateSettings.Commands.UpdateFinanceInvoiceTemplateSetting;

public class UpdateFinanceInvoiceTemplateSettingCommand : IRequest
{
    public Guid Id { get; set; }
    public string? FIRBTemplateJsonSettings { get; set; }
}








































