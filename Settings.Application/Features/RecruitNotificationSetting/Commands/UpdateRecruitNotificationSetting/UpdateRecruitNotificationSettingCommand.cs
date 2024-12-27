using MediatR;

namespace Settings.Application.Features.RecruitNotificationSettings.Commands.UpdateRecruitNotificationSetting;

public class UpdateRecruitNotificationSettingCommand : IRequest
{
    public int Id { get; set; }
    public string? CBEMailJsonSettings { get; set; }
    public string? CBEMailNotificationJsonSettings { get; set; }
}























