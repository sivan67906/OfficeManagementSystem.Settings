using MediatR;

namespace Settings.Application.Features.PurchaseOrders.Commands.CreatePurchaseOrder;
public class CreatePurchaseOrderCommand : IRequest<int>
{
    public int Id { get; set; }
    public string? PurchaseOrderPrefix { get; set; }
    public string? PurchaseOrderNumberSeperater { get; set; }
    public string? PurchaseOrderNumberDigits { get; set; }
    public string? PurchaseOrderNumberExample { get; set; }
}
