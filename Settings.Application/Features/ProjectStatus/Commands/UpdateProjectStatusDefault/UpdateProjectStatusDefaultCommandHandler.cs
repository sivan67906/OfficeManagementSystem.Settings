using MediatR;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.ProjectStatus.Commands.UpdateProjectStatusDefault;
internal class UpdateProjectStatusDefaultCommandHandler : IRequestHandler<UpdateProjectStatusDefaultCommand>
{
    private readonly IGenericRepository<Settings.Domain.Entities.ProjectStatus> _projectStatusRepository;

    public UpdateProjectStatusDefaultCommandHandler(
        IGenericRepository<Settings.Domain.Entities.ProjectStatus> projectStatusRepository)
    {
        _projectStatusRepository = projectStatusRepository;
    }

    public async System.Threading.Tasks.Task Handle(UpdateProjectStatusDefaultCommand request, CancellationToken cancellationToken)
    {
        var projectStatus = await _projectStatusRepository.GetByIdAsync(request.Id);



        var projectStatusUpdate = new Settings.Domain.Entities.ProjectStatus
        {
            Id = projectStatus.Id,
            Name = projectStatus.Name,
            ColorCode = projectStatus.ColorCode,
            IsDefaultStatus = true,
            Status = projectStatus.Status,
            UpdatedDate = DateTime.Now
        };

        await _projectStatusRepository.UpdateAsync(projectStatusUpdate);
    }
}
