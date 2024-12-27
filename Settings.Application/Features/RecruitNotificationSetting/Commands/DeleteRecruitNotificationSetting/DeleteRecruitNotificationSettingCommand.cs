using MediatR;

namespace Settings.Application.Features.RecruitNotificationSettings.Commands.DeleteRecruitNotificationSetting
{
    public class DeleteRecruitNotificationSettingCommand : IRequest
    {
        public int Id { get; set; }
    }
}
























