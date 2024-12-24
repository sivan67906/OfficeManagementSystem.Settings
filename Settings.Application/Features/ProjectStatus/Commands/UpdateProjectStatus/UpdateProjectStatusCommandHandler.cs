using MediatR;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.ProjectStatuses.Commands.UpdateProjectStatus;

internal class UpdateProjectStatusCommandHandler : IRequestHandler<UpdateProjectStatusCommand>
{
    private readonly IGenericRepository<Settings.Domain.Entities.ProjectStatus> _projectStatusRepository;

    public UpdateProjectStatusCommandHandler(
        IGenericRepository<Settings.Domain.Entities.ProjectStatus> projectStatusRepository) =>
        _projectStatusRepository = projectStatusRepository;

    public async System.Threading.Tasks.Task Handle(UpdateProjectStatusCommand request, CancellationToken cancellationToken)
    {
        var projectStatus = new Settings.Domain.Entities.ProjectStatus
        {
            Id = request.Id,
            Name = request.Name,
            ColorCode = request.ColorCode,
            IsDefaultStatus = request.IsDefaultStatus,
            Status = request.Status,
            UpdatedDate = DateTime.Now
        };

        await _projectStatusRepository.UpdateAsync(projectStatus);
    }
}
















