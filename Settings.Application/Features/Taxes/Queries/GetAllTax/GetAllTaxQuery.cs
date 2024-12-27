using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Taxes.Queries.GetAllTax;
public class GetAllTaxQuery : IRequest<IEnumerable<TaxDTO>>
{
}
