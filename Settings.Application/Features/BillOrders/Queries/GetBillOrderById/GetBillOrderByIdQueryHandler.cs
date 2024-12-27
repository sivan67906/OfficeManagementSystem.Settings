using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.BillOrders.Queries.GetBillOrderById;
public class GetBillOrderByIdQueryHandler : IRequestHandler<GetBillOrderByIdQuery, BillOrderDTO>
{
    private readonly IGenericRepository<BillOrder> _billorderrepo;
    public GetBillOrderByIdQueryHandler(IGenericRepository<BillOrder> billorderrepo)
    {
        _billorderrepo = billorderrepo;
    }

    public async Task<BillOrderDTO> Handle(GetBillOrderByIdQuery request, CancellationToken cancellationToken)
    {
        var bill = await _billorderrepo.GetByIdAsync(request.Id);
        if (bill == null) return null;
        return new BillOrderDTO
        {
            Id = bill.Id,
            BillOrderPrefix = bill.BillOrderPrefix,
            BillOrderNumberSeperater = bill.BillOrderNumberSeperater,
            BillOrderNumberDigits = bill.BillOrderNumberDigits,
            BillOrderNumberExample = bill.BillOrderNumberExample,
        };
    }
}
