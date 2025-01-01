using MediatR;

namespace Settings.Application.Features.RecruitFooterSettings.Commands.DeleteRecruitFooterSetting
{
    public class DeleteRecruitFooterSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
























