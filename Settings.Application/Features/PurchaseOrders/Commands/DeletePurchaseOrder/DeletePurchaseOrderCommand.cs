using MediatR;

namespace Settings.Application.Features.PurchaseOrders.Commands.DeletePurchaseOrder;
public class DeletePurchaseOrderCommand : IRequest
{
    public int Id { get; set; }
}
