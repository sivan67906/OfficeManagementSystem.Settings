//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.FinanceInvoiceSettings.Queries.GetFinanceInvoiceSettingById
{
    public class GetFinanceInvoiceSettingByIdQuery : IRequest<FinanceInvoiceSettingDTO>
    {
        public Guid Id { get; set; }
    }
}












































