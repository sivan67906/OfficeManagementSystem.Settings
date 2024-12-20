using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Payments.Commands.UpdatePayment;
public class UpdatePaymentCommandHandler : IRequestHandler<UpdatePaymentCommand, int>
{
    private readonly IGenericRepository<Payment> _repository;
    public UpdatePaymentCommandHandler(IGenericRepository<Payment> repository)
    {
        _repository = repository;
    }

    public async Task<int> Handle(UpdatePaymentCommand request, CancellationToken cancellationToken)
    {
        var product = new Payment
        {
            Id = request.Id,
            Method = request.Method,
            Description = request.Description,
            Status = request.Status
        };
        await _repository.UpdateAsync(product);
        return request.Id;
    }
}
