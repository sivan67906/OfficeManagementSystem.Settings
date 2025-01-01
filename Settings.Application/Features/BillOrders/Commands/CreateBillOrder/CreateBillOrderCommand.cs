using MediatR;

namespace Settings.Application.Features.BillOrders.Commands.CreateBillOrder;
public class CreateBillOrderCommand : IRequest<Guid>
{
    
    public string? BillOrderPrefix { get; set; }
    public string? BillOrderNumberSeperater { get; set; }
    public string? BillOrderNumberDigits { get; set; }
    public string? BillOrderNumberExample { get; set; }
}
