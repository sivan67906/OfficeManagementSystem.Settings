using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Payments.Commands.DeletePayment;
public class DeletePaymentCommandHandler : IRequestHandler<DeletePaymentCommand>
{
    private readonly IGenericRepository<Payment> _messageRepository;
    public DeletePaymentCommandHandler(IGenericRepository<Payment> messageRepository)
    {
        _messageRepository = messageRepository;
    }

    public async System.Threading.Tasks.Task Handle(DeletePaymentCommand request, CancellationToken cancellationToken)
    {
        if (request == null || request.Id == null)
        {
            throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
        }

        await _messageRepository.DeleteAsync(request.Id);
    }
}
