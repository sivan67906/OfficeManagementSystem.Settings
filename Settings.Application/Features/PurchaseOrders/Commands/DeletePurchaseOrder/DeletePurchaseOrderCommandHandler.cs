using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.PurchaseOrders.Commands.DeletePurchaseOrder;
public class DeletePurchaseOrderCommandHandler : IRequestHandler<DeletePurchaseOrderCommand>
{
    private readonly IGenericRepository<PurchaseOrder> _purchaseOrderRepository;
    public DeletePurchaseOrderCommandHandler(IGenericRepository<PurchaseOrder> purchaseOrderRepository)
    {
        _purchaseOrderRepository = purchaseOrderRepository;
    }

    public async System.Threading.Tasks.Task Handle(DeletePurchaseOrderCommand request, CancellationToken cancellationToken)
    {
        if (request == null || request.Id == null)
        {
            throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
        }

        await _purchaseOrderRepository.DeleteAsync(request.Id);
    }
}
