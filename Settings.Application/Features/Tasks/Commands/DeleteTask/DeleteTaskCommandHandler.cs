using MediatR;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Tasks.Commands.DeleteTask;
public class DeleteTaskCommandHandler : IRequestHandler<DeleteTaskCommand>
{
    private readonly IGenericRepository<Domain.Entities.Task> _repository;
    public DeleteTaskCommandHandler(IGenericRepository<Domain.Entities.Task> repository)
    {
        _repository = repository;
    }

    public async System.Threading.Tasks.Task Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
    {
        if (request == null || request.Id == null)
        {
            throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
        }

        await _repository.DeleteAsync(request.Id);
    }
}
