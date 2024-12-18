﻿using MediatR;

namespace Settings.Application.Features.Currencies.Commands.UpdateCurrency;
public class UpdateCurrencyCommand : IRequest<int>
{
    public int Id { get; set; }
    public string? CurrencyName { get; set; }
    public string? CurrencySymbol { get; set; }
    public string? CurrencyCode { get; set; }
    public string? IsCryptocurrency { get; set; }
    public int USDPrice { get; set; }
    public int ExchangeRate { get; set; }
    public string? CurrencyPosition { get; set; }
    public string? ThousandSeparator { get; set; }
    public string? DecimalSeparator { get; set; }
    public int NumberofDecimals { get; set; }
}
