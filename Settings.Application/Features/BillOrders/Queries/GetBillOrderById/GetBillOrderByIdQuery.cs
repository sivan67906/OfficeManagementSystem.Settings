using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.BillOrders.Queries.GetBillOrderById;
public class GetBillOrderByIdQuery : IRequest<BillOrderDTO>
{
    public int Id { get; set; }
}
