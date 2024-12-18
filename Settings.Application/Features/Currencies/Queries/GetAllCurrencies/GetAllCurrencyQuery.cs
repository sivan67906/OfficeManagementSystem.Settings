using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Currencies.Queries.GetAllCurrencies;
public class GetAllCurrencyQuery : IRequest<IEnumerable<CurrencyDTO>>
{
}
