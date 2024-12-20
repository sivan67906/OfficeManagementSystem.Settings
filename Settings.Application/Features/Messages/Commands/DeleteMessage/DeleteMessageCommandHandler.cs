using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Messages.Commands.DeleteMessage;
public class DeleteMessageCommandHandler : IRequestHandler<DeleteMessageCommand>
{
    private readonly IGenericRepository<Message> _repository;
    public DeleteMessageCommandHandler(IGenericRepository<Message> repository) => _repository = repository;

    public async System.Threading.Tasks.Task Handle(DeleteMessageCommand request, CancellationToken cancellationToken)
    {
        if (request == null || request.Id == null)
        {
            throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
        }

        await _repository.DeleteAsync(request.Id);
    }
}
