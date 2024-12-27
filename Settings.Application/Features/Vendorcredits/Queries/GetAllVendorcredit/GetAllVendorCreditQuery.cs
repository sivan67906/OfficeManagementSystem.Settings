using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Vendorcredits.Queries.GetAllVendorcredit;
public class GetAllVendorCreditQuery : IRequest<IEnumerable<VendorCreditDTO>>
{
}
