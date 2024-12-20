using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Payments.Queries.GetPaymentById;
public class GetPaymentByIdQueryHandler : IRequestHandler<GetPaymentByIdQuery, PaymentDTO>
{
    private readonly IGenericRepository<Payment> _repository;
    public GetPaymentByIdQueryHandler(IGenericRepository<Payment> repository)
    {
        _repository = repository;
    }

    public async Task<PaymentDTO> Handle(GetPaymentByIdQuery request, CancellationToken cancellationToken)
    {
        var client = await _repository.GetByIdAsync(request.Id);
        if (client == null) return null;
        return new PaymentDTO
        {
            Id = client.Id,
            Method = client.Method,
            Description = client.Description,
            Status = client.Status
        };
    }
}
