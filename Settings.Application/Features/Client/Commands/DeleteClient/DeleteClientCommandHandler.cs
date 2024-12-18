using MediatR;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Client.Commands.DeleteClient;
public class DeleteClientCommandHandler : IRequestHandler<DeleteClientCommand>
{
    private readonly IGenericRepository<Domain.Entities.Client> _repository;
    public DeleteClientCommandHandler(IGenericRepository<Domain.Entities.Client> repository) => _repository = repository;

    public async Task Handle(DeleteClientCommand request, CancellationToken cancellationToken)
    {
        if (request == null || request.Id == null)
        {
            throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
        }

        await _repository.DeleteAsync(request.Id);
    }
}