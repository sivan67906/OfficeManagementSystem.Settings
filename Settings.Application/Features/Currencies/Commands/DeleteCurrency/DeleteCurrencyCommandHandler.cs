using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Currencies.Commands.DeleteCurrency;
public class DeleteCurrencyCommandHandler : IRequestHandler<DeleteCurrencyCommand>
{
    private readonly IGenericRepository<Currency> _currencyRepo;
    public DeleteCurrencyCommandHandler(IGenericRepository<Currency> currencyRepo) => _currencyRepo = currencyRepo;

    public async System.Threading.Tasks.Task Handle(DeleteCurrencyCommand request, CancellationToken cancellationToken)
    {
        if (request == null || request.Id == null)
        {
            throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
        }

        await _currencyRepo.DeleteAsync(request.Id);
    }
}
