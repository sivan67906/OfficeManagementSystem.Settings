using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Currencies.Commands.UpdateCurrency;
public class UpdateCurrencyCommandHandler : IRequestHandler<UpdateCurrencyCommand, int>
{
    private readonly IGenericRepository<Currency> _currencyRepository;
    public UpdateCurrencyCommandHandler(IGenericRepository<Currency> currencyRepository) => _currencyRepository = currencyRepository;

    public async Task<int> Handle(UpdateCurrencyCommand request, CancellationToken cancellationToken)
    {
        var currency = new Currency
        {
            Id = request.Id,
            CurrencyName = request.CurrencyName,
            CurrencySymbol = request.CurrencySymbol,
            CurrencyCode = request.CurrencyCode,
            IsCryptocurrency = request.IsCryptocurrency,
            USDPrice = request.USDPrice,
            ExchangeRate = request.ExchangeRate,

            CurrencyPosition = request.CurrencyPosition,
            ThousandSeparator = request.ThousandSeparator,

            DecimalSeparator = request.DecimalSeparator,
            NumberofDecimals = request.NumberofDecimals,
        };
        await _currencyRepository.UpdateAsync(currency);
        return request.Id;
    }
}
