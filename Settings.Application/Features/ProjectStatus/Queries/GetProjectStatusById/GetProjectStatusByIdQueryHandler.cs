using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.ProjectStatuses.Queries.GetProjectStatusById;

internal class GetProjectStatusByIdQueryHandler : IRequestHandler<GetProjectStatusByIdQuery, ProjectStatusDTO>
{
    private readonly IGenericRepository<Settings.Domain.Entities.ProjectStatus> _projectStatusRepository;

    public GetProjectStatusByIdQueryHandler(
        IGenericRepository<Settings.Domain.Entities.ProjectStatus> projectStatusRepository) =>
        _projectStatusRepository = projectStatusRepository;

    public async Task<ProjectStatusDTO> Handle(GetProjectStatusByIdQuery request, CancellationToken cancellationToken)
    {
        var projectStatus = await _projectStatusRepository.GetByIdAsync(request.Id);
        if (projectStatus == null) return null;
        return new ProjectStatusDTO
        {
            Id = projectStatus.Id,
            Name = projectStatus.Name,
            ColorCode = projectStatus.ColorCode,
            IsDefaultStatus = projectStatus.IsDefaultStatus,
            Status = projectStatus.Status
        };
    }
}
















