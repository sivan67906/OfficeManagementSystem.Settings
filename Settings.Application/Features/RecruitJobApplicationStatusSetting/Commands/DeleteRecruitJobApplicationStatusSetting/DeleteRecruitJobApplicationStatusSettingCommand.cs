using MediatR;

namespace Settings.Application.Features.RecruitJobApplicationStatusSettings.Commands.DeleteRecruitJobApplicationStatusSetting
{
    public class DeleteRecruitJobApplicationStatusSettingCommand : IRequest
    {
        public int Id { get; set; }
    }
}
























