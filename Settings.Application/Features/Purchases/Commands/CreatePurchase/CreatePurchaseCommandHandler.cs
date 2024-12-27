using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Purchases.Commands.CreatePurchase;
public class CreatePurchaseCommandHandler : IRequestHandler<CreatePurchaseCommand, int>
{
    private readonly IGenericRepository<Purchase> _purchaseRepository;
    public CreatePurchaseCommandHandler(IGenericRepository<Purchase> purchaseRepository)
    {
        _purchaseRepository = purchaseRepository;
    }

    public async Task<int> Handle(CreatePurchaseCommand request, CancellationToken cancellationToken)
    {
        var client = new Purchase
        {
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
        await _purchaseRepository.CreateAsync(client);
        return client.Id;
    }
}
