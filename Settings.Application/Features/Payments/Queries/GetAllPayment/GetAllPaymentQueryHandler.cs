using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Payments.Queries.GetAllPayment;
public class GetAllPaymentQueryHandler : IRequestHandler<GetAllPaymentQuery, IEnumerable<PaymentDTO>>
{
    private readonly IGenericRepository<Payment> _repository;
    public GetAllPaymentQueryHandler(IGenericRepository<Payment> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<PaymentDTO>> Handle(GetAllPaymentQuery request, CancellationToken cancellationToken)
    {
        var clients = await _repository.GetAllAsync();

        var clientlist = clients.Select(x => new PaymentDTO
        {
            Id = x.Id,
            Method = x.Method,
            Description = x.Description,
            Status = x.Status
        }).ToList();

        return clientlist;
    }
}
