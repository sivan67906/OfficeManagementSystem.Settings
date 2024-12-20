using MediatR;

namespace Settings.Application.Features.Payments.Commands.UpdatePayment;
public class UpdatePaymentCommand : IRequest<int>
{
    public int Id { get; set; }
    public string? Method { get; set; }
    public string? Description { get; set; }
    public bool Status { get; set; } = true;
}
