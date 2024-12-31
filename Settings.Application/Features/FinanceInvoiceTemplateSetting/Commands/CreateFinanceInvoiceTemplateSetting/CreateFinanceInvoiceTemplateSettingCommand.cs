using MediatR;

namespace Settings.Application.Features.FinanceInvoiceTemplateSettings.Commands.CreateFinanceInvoiceTemplateSetting;

public class CreateFinanceInvoiceTemplateSettingCommand : IRequest
{
    public string? FIRBTemplateJsonSettings { get; set; }
}








































