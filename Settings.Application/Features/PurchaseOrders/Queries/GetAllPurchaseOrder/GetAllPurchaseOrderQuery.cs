using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.PurchaseOrders.Queries.GetAllPurchaseOrder;
public class GetAllPurchaseOrderQuery : IRequest<IEnumerable<PurchaseOrderDTO>>
{
}
