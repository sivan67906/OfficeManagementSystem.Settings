using MediatR;

namespace Settings.Application.Features.BillOrders.Commands.CreateBillOrder;
public class CreateBillOrderCommand : IRequest<int>
{
    public int Id { get; set; }
    public string? BillOrderPrefix { get; set; }
    public string? BillOrderNumberSeperater { get; set; }
    public string? BillOrderNumberDigits { get; set; }
    public string? BillOrderNumberExample { get; set; }
}
