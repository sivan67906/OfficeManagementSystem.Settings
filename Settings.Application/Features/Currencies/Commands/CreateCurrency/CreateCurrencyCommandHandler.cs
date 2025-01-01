using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Currencies.Commands.CreateCurrency;
public class CreateCurrencyCommandHandler : IRequestHandler<CreateCurrencyCommand, Guid>
{
    private readonly IGenericRepository<Currency> _currencyRepo;
    public CreateCurrencyCommandHandler(IGenericRepository<Currency> currencyRepo) => _currencyRepo = currencyRepo;

    public async Task<Guid> Handle(CreateCurrencyCommand request, CancellationToken cancellationToken)
    {
        var currency = new Currency
        {
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
        await _currencyRepo.CreateAsync(currency);
        return currency.Id;
    }
}
