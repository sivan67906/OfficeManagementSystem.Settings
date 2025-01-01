//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.FinanceInvoiceTemplateSettings.Queries.GetFinanceInvoiceTemplateSettingById
{
    public class GetFinanceInvoiceTemplateSettingByIdQuery : IRequest<FinanceInvoiceTemplateSettingDTO>
    {
        public Guid Id { get; set; }
    }
}








































