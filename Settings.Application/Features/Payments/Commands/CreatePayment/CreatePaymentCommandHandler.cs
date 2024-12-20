using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Payments.Commands.CreatePayment;
public class CreatePaymentCommandHandler : IRequestHandler<CreatePaymentCommand, int>
{
    private readonly IGenericRepository<Payment> _repository;
    public CreatePaymentCommandHandler(IGenericRepository<Payment> repository)
    {
        _repository = repository;
    }

    public async Task<int> Handle(CreatePaymentCommand request, CancellationToken cancellationToken)
    {
        var client = new Payment
        {
            Method = request.Method,
            Description = request.Description,
            Status = request.Status
        };

        await _repository.CreateAsync(client);
        return client.Id;
    }
}
