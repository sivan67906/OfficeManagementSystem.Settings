using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.BillOrders.Commands.UpdateBillOrder;
public class UpdateBillOrderCommandHandler : IRequestHandler<UpdateBillOrderCommand, Guid>
{
    private readonly IGenericRepository<BillOrder> _billOrdersRepository;
    public UpdateBillOrderCommandHandler(IGenericRepository<BillOrder> billOrdersRepository)
    {
        _billOrdersRepository = billOrdersRepository;
    }

    public async Task<Guid> Handle(UpdateBillOrderCommand request, CancellationToken cancellationToken)
    {
        var billOrder = new BillOrder
        {
            Id = request.Id,
            BillOrderPrefix = request.BillOrderPrefix,
            BillOrderNumberSeperater = request.BillOrderNumberSeperater,
            BillOrderNumberDigits = request.BillOrderNumberDigits,
            BillOrderNumberExample = request.BillOrderNumberExample,
        };
        await _billOrdersRepository.UpdateAsync(billOrder);
        return request.Id;
    }
}
