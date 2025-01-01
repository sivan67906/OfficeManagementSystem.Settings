using MediatR;

namespace Settings.Application.Features.RecruitNotificationSettings.Commands.DeleteRecruitNotificationSetting
{
    public class DeleteRecruitNotificationSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
























