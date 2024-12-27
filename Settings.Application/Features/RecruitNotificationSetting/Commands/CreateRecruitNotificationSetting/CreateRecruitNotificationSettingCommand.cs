using MediatR;

namespace Settings.Application.Features.RecruitNotificationSettings.Commands.CreateRecruitNotificationSetting;

public class CreateRecruitNotificationSettingCommand : IRequest
{
    public string? CBEMailJsonSettings { get; set; }
    public string? CBEMailNotificationJsonSettings { get; set; }
}
























