using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Purchases.Commands.UpdatePurchase;
public class UpdatePurchaseCommandHandler : IRequestHandler<UpdatePurchaseCommand, Guid>
{
    private readonly IGenericRepository<Purchase> _purchaseRepository;
    public UpdatePurchaseCommandHandler(IGenericRepository<Purchase> purchaseRepository)
    {
        _purchaseRepository = purchaseRepository;
    }

    public async Task<Guid> Handle(UpdatePurchaseCommand request, CancellationToken cancellationToken)
    {
        var product = new Purchase
        {
            Id = request.Id,
            PurchaseOrderPrefix = request.PurchaseOrderPrefix,
            PurchaseOrderNumberSeperater = request.PurchaseOrderNumberSeperater,
            PurchaseOrderNumberDigits = request.PurchaseOrderNumberDigits,
            PurchaseOrderNumberExample = request.PurchaseOrderNumberExample,
            BillOrderPrefix = request.BillOrderPrefix,
            BillOrderNumberSeperater = request.BillOrderNumberSeperater,

            BillOrderNumberDigits = request.BillOrderNumberDigits,
            BillOrderNumberExample = request.BillOrderNumberExample,

            VendorCreditPrefix = request.VendorCreditPrefix,
            VendorCreditNumberSeperater = request.VendorCreditNumberSeperater,
            VendorCreditNumberDigits = request.VendorCreditNumberDigits,
            VendorCreditNumberExample = request.VendorCreditNumberExample,
        };
        await _purchaseRepository.UpdateAsync(product);
        return request.Id;
    }
}
