using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.BillOrders.Queries.GetAllBillOrder;
public class GetAllBillOrderQuery : IRequest<IEnumerable<BillOrderDTO>>
{

}
