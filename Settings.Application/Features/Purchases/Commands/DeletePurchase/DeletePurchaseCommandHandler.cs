using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Purchases.Commands.DeletePurchase;
public class DeletePurchaseCommandHandler : IRequestHandler<DeletePurchaseCommand>
{
    private readonly IGenericRepository<Purchase> _purchaseRepository;
    public DeletePurchaseCommandHandler(IGenericRepository<Purchase> purchaseRepository)
    {
        _purchaseRepository = purchaseRepository;
    }

    public async System.Threading.Tasks.Task Handle(DeletePurchaseCommand request, CancellationToken cancellationToken)
    {
        if (request == null || request.Id == null)
        {
            throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
        }

        await _purchaseRepository.DeleteAsync(request.Id);
    }
}
