using MediatR;

namespace Settings.Application.Features.FinanceInvoiceTemplateSettings.Commands.DeleteFinanceInvoiceTemplateSetting
{
    public class DeleteFinanceInvoiceTemplateSettingCommand : IRequest
    {
        public int Id { get; set; }
    }
}








































