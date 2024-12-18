using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Currencies.Queries.GetAllCurrencies;
public class GetAllCurrencyQueryHandler : IRequestHandler<GetAllCurrencyQuery, IEnumerable<CurrencyDTO>>
{
    private readonly IGenericRepository<Currency> _currencyRepository;

    public GetAllCurrencyQueryHandler(IGenericRepository<Currency> currencyRepository) => _currencyRepository = currencyRepository;

    async Task<IEnumerable<CurrencyDTO>> IRequestHandler<GetAllCurrencyQuery, IEnumerable<CurrencyDTO>>.Handle(GetAllCurrencyQuery request, CancellationToken cancellationToken)
    {
        var currencys = await _currencyRepository.GetAllAsync();

        var currencylist = currencys.Select(x => new CurrencyDTO
        {
            Id = x.Id,
            CurrencyName = x.CurrencyName,
            CurrencySymbol = x.CurrencySymbol,
            CurrencyCode = x.CurrencyCode,
            IsCryptocurrency = x.IsCryptocurrency,
            USDPrice = x.USDPrice,
            ExchangeRate = x.ExchangeRate,

            CurrencyPosition = x.CurrencyPosition,
            ThousandSeparator = x.ThousandSeparator,

            DecimalSeparator = x.DecimalSeparator,
            NumberofDecimals = x.NumberofDecimals,
        }).ToList();

        return currencylist;
    }
}
