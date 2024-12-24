using MediatR;

namespace Settings.Application.Features.ProjectSettings.Commands.UpdateProjectSetting;

public class UpdateProjectSettingCommand : IRequest
{
    public int Id { get; set; }
    public bool IsSendReminder { get; set; }
    public int SendReminderTo { get; set; }
    public int ProjectReminderPersonId { get; set; }
    public int RemindBefore { get; set; }
}




















