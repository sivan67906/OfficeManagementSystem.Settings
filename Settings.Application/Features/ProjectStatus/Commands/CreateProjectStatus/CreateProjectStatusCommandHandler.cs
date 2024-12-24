using MediatR;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.ProjectStatuses.Commands.CreateProjectStatus;

internal class CreateProjectStatusCommandHandler(
    IGenericRepository<Settings.Domain.Entities.ProjectStatus> projectStatusRepository) : IRequestHandler<CreateProjectStatusCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateProjectStatusCommand request, CancellationToken cancellationToken)
    {
        var projectStatus = new Settings.Domain.Entities.ProjectStatus
        {
            Name = request.Name,
            ColorCode = request.ColorCode,
            IsDefaultStatus = request.IsDefaultStatus,
            Status = request.Status,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await projectStatusRepository.CreateAsync(projectStatus);
    }
}
















