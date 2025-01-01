using MediatR;

namespace Settings.Application.Features.RecruitJobApplicationStatusSettings.Commands.DeleteRecruitJobApplicationStatusSetting
{
    public class DeleteRecruitJobApplicationStatusSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
























