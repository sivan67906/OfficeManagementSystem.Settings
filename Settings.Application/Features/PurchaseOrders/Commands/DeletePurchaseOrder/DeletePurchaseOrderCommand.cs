using MediatR;

namespace Settings.Application.Features.PurchaseOrders.Commands.DeletePurchaseOrder;
public class DeletePurchaseOrderCommand : IRequest
{
    public Guid Id { get; set; }
}
