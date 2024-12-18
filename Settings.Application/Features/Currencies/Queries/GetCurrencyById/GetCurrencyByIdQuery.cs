using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Currencies.Queries.GetCurrencyById;
public class GetCurrencyByIdQuery : IRequest<CurrencyDTO>
{
    public int Id { get; set; }
}
