using MediatR;

namespace Settings.Application.Features.BillOrders.Commands.DeleteBillOrder;
public class DeleteBillOrderCommand : IRequest
{
    public int Id { get; set; }
}
