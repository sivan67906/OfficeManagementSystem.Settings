using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.PurchaseOrders.Commands.CreatePurchaseOrder;
public class CreatePurchaseOrderCommandHandler : IRequestHandler<CreatePurchaseOrderCommand, Guid>
{
    private readonly IGenericRepository<PurchaseOrder> _purchaseOrderRepository;
    public CreatePurchaseOrderCommandHandler(IGenericRepository<PurchaseOrder> purchaseOrderRepository)
    {
        _purchaseOrderRepository = purchaseOrderRepository;
    }

    public async Task<Guid> Handle(CreatePurchaseOrderCommand request, CancellationToken cancellationToken)
    {
        var client = new PurchaseOrder
        {
            PurchaseOrderPrefix = request.PurchaseOrderPrefix,
            PurchaseOrderNumberSeperater = request.PurchaseOrderNumberSeperater,
            PurchaseOrderNumberDigits = request.PurchaseOrderNumberDigits,
            PurchaseOrderNumberExample = request.PurchaseOrderNumberExample,
        };
        await _purchaseOrderRepository.CreateAsync(client);
        return client.Id;
    }
}
