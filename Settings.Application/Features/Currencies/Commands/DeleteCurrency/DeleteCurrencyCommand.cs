using MediatR;

namespace Settings.Application.Features.Currencies.Commands.DeleteCurrency;
public class DeleteCurrencyCommand : IRequest
{
    public int Id { get; set; }
}
