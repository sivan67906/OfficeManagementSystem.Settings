using MediatR;

namespace Settings.Application.Features.Payments.Commands.DeletePayment;
public class DeletePaymentCommand :IRequest
{
    public int Id { get; set; }
}
