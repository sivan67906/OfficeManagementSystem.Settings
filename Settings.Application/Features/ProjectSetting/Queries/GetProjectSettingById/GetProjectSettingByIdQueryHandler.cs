using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.ProjectSettings.Queries.GetProjectSettingById;

internal class GetProjectSettingByIdQueryHandler : IRequestHandler<GetProjectSettingByIdQuery, ProjectSettingDTO>
{
    private readonly IGenericRepository<ProjectSetting> _projectSettingRepository;

    public GetProjectSettingByIdQueryHandler(
        IGenericRepository<ProjectSetting> projectSettingRepository) =>
        _projectSettingRepository = projectSettingRepository;

    public async Task<ProjectSettingDTO> Handle(GetProjectSettingByIdQuery request, CancellationToken cancellationToken)
    {
        var projectSetting = await _projectSettingRepository.GetByIdAsync(request.Id);
        if (projectSetting == null) return null;
        return new ProjectSettingDTO
        {
            Id = projectSetting.Id,
            IsSendReminder = projectSetting.IsSendReminder,
            RemindBefore = projectSetting.RemindBefore
        };
    }
}




















