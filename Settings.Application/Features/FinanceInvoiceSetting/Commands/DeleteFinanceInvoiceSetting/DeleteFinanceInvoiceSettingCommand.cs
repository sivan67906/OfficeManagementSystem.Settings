using MediatR;

namespace Settings.Application.Features.FinanceInvoiceSettings.Commands.DeleteFinanceInvoiceSetting
{
    public class DeleteFinanceInvoiceSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}












































