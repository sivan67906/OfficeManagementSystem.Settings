using MediatR;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.ProjectStatuses.Commands.DeleteProjectStatus;

internal class DeleteProjectStatusCommandHandler : IRequestHandler<DeleteProjectStatusCommand>
{
    private readonly IGenericRepository<Settings.Domain.Entities.ProjectStatus> _projectStatusRepository;

    public DeleteProjectStatusCommandHandler(
        IGenericRepository<Settings.Domain.Entities.ProjectStatus> projectStatusRepository) =>
        _projectStatusRepository = projectStatusRepository;
    public async System.Threading.Tasks.Task Handle(DeleteProjectStatusCommand request, CancellationToken cancellationToken)
    {
        await _projectStatusRepository.DeleteAsync(request.Id);
    }
}