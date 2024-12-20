using MediatR;

namespace Settings.Application.Features.Payments.Commands.CreatePayment;
public class CreatePaymentCommand : IRequest<int>
{
    public string? Method { get; set; }
    public string? Description { get; set; }
    public bool Status { get; set; } = true;
}
