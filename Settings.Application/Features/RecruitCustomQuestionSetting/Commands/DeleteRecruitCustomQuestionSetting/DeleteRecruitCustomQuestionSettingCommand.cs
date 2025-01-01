using MediatR;

namespace Settings.Application.Features.RecruitCustomQuestionSettings.Commands.DeleteRecruitCustomQuestionSetting
{
    public class DeleteRecruitCustomQuestionSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
























