using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.BillOrders.Queries.GetAllBillOrder;
public class GetAllBillOrderQueryHandler : IRequestHandler<GetAllBillOrderQuery, IEnumerable<BillOrderDTO>>
{
    private readonly IGenericRepository<BillOrder> _billorderrepository;
    public GetAllBillOrderQueryHandler(IGenericRepository<BillOrder> billorderrepository)
    {
        _billorderrepository = billorderrepository;
    }

    public async Task<IEnumerable<BillOrderDTO>> Handle(GetAllBillOrderQuery request, CancellationToken cancellationToken)
    {
        var billOrders = await _billorderrepository.GetAllAsync();

        var billlist = billOrders.Select(x => new BillOrderDTO
        {
            Id = x.Id,
            BillOrderPrefix = x.BillOrderPrefix,
            BillOrderNumberSeperater = x.BillOrderNumberSeperater,
            BillOrderNumberDigits = x.BillOrderNumberDigits,
            BillOrderNumberExample = x.BillOrderNumberExample,
        }).ToList();

        return billlist;
    }
}
