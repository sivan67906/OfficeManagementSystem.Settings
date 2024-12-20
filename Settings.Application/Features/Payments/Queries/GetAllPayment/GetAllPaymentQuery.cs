using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Payments.Queries.GetAllPayment;
public class GetAllPaymentQuery : IRequest<IEnumerable<PaymentDTO>>
{
}
