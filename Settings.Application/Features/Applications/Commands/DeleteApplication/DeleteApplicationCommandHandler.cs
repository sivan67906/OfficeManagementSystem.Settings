using MediatR;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Applications.Commands.DeleteApplication;
public class DeleteApplicationCommandHandler : IRequestHandler<DeleteApplicationCommand>
{
    private readonly IGenericRepository<Domain.Entities.Applications> _appliRepo;

    public DeleteApplicationCommandHandler(IGenericRepository<Domain.Entities.Applications> repository) => _appliRepo = repository;

    public async System.Threading.Tasks.Task Handle(DeleteApplicationCommand request, CancellationToken cancellationToken)
    {
        if (request == null || request.Id == null)
        {
            throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
        }

        await _appliRepo.DeleteAsync(request.Id);
    }
}
