using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Payments.Queries.GetPaymentById;
public class GetPaymentByIdQuery : IRequest<PaymentDTO>
{
    public int Id { get; set; }
}
