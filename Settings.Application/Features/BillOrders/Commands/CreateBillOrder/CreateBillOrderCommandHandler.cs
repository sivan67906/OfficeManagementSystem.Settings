using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.BillOrders.Commands.CreateBillOrder;
public class CreateBillOrderCommandHandler : IRequestHandler<CreateBillOrderCommand, Guid>
{
    private readonly IGenericRepository<BillOrder> _billOrdersRepository;
    public CreateBillOrderCommandHandler(IGenericRepository<BillOrder> billOrdersRepository)
    {
        _billOrdersRepository = billOrdersRepository;
    }

    public async Task<Guid> Handle(CreateBillOrderCommand request, CancellationToken cancellationToken)
    {
        var billOrder = new BillOrder
        {
            BillOrderPrefix = request.BillOrderPrefix,
            BillOrderNumberSeperater = request.BillOrderNumberSeperater,
            BillOrderNumberDigits = request.BillOrderNumberDigits,
            BillOrderNumberExample = request.BillOrderNumberExample,
            
        };
        await _billOrdersRepository.CreateAsync(billOrder);
        return billOrder.Id;
    }
}
