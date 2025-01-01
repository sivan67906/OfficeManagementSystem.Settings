using MediatR;

namespace Settings.Application.Features.Currencies.Commands.DeleteCurrency;
public class DeleteCurrencyCommand : IRequest
{
    public Guid Id { get; set; }
}
