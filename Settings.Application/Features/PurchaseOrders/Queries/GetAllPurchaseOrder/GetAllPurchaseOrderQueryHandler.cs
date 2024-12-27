using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.PurchaseOrders.Queries.GetAllPurchaseOrder;
public class GetAllPurchaseOrderQueryHandler : IRequestHandler<GetAllPurchaseOrderQuery, IEnumerable<PurchaseOrderDTO>>
{
    private readonly IGenericRepository<PurchaseOrder> _purchaseorderrepo;
    public GetAllPurchaseOrderQueryHandler(IGenericRepository<PurchaseOrder> purchaseorderrepo)
    {
        _purchaseorderrepo = purchaseorderrepo;
    }

    public async Task<IEnumerable<PurchaseOrderDTO>> Handle(GetAllPurchaseOrderQuery request, CancellationToken cancellationToken)
    {
        var purchaseOrders = await _purchaseorderrepo.GetAllAsync();

        var purchaselist = purchaseOrders.Select(x => new PurchaseOrderDTO
        {
            Id = x.Id,
            PurchaseOrderPrefix = x.PurchaseOrderPrefix,
            PurchaseOrderNumberSeperater = x.PurchaseOrderNumberSeperater,
            PurchaseOrderNumberDigits = x.PurchaseOrderNumberDigits,
            PurchaseOrderNumberExample = x.PurchaseOrderNumberExample,
        }).ToList();

        return purchaselist;
    }
}
