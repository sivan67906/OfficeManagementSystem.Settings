using MediatR;

namespace Settings.Application.Features.ProjectSettings.Commands.CreateProjectSetting;

public class CreateProjectSettingCommand : IRequest
{
    public bool IsSendReminder { get; set; }
    public int SendReminderTo { get; set; }
    public int RemindBefore { get; set; }
    public int ProjectReminderPersonId { get; set; }
}




















