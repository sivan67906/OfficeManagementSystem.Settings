using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Vendorcredits.Queries.GetBillVendorcredit;
public class GetVendorCreditByIdQuery : IRequest<VendorCreditDTO>
{
    public int Id { get; set; }
}
