using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.PurchaseOrders.Queries.GetPurchaseOrderById;
public class GetPurchaseOrderByIdQuery : IRequest<PurchaseOrderDTO>
{
    public int Id { get; set; }
}
