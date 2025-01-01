using MediatR;

namespace Settings.Application.Features.BillOrders.Commands.DeleteBillOrder;
public class DeleteBillOrderCommand : IRequest
{
    public Guid Id { get; set; }
}
