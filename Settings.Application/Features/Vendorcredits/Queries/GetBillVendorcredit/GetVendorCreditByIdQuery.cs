using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Vendorcredits.Queries.GetBillVendorcredit;
public class GetVendorCreditByIdQuery : IRequest<VendorCreditDTO>
{
    public Guid Id { get; set; }
}
