using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.BillOrders.Commands.DeleteBillOrder;
public class DeleteBillOrderCommandHandler : IRequestHandler<DeleteBillOrderCommand>
{
    private readonly IGenericRepository<BillOrder> _repository;
    public DeleteBillOrderCommandHandler(IGenericRepository<BillOrder> repository)
    {
        _repository = repository;
    }

    public async System.Threading.Tasks.Task Handle(DeleteBillOrderCommand request, CancellationToken cancellationToken)
    {
        if (request == null || request.Id == null)
        {
            throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
        }

        await _repository.DeleteAsync(request.Id);
    }
}
