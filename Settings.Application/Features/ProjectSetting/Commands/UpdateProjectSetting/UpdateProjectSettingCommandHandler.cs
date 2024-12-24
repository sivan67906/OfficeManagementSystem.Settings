using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.ProjectSettings.Commands.UpdateProjectSetting;

internal class UpdateProjectSettingCommandHandler : IRequestHandler<UpdateProjectSettingCommand>
{
    private readonly IGenericRepository<ProjectSetting> _projectSettingRepository;

    public UpdateProjectSettingCommandHandler(
        IGenericRepository<ProjectSetting> projectSettingRepository) =>
        _projectSettingRepository = projectSettingRepository;

    public async System.Threading.Tasks.Task Handle(UpdateProjectSettingCommand request, CancellationToken cancellationToken)
    {
        var projectSetting = new ProjectSetting
        {
            Id = request.Id,
            IsSendReminder = request.IsSendReminder,
            RemindBefore = request.RemindBefore,
            ProjectReminderPersonId = request.ProjectReminderPersonId,
            UpdatedDate = DateTime.Now
        };

        await _projectSettingRepository.UpdateAsync(projectSetting);
    }
}




















