using MediatR;

namespace Settings.Application.Features.RecruitGeneralSettings.Commands.DeleteRecruitGeneralSetting
{
    public class DeleteRecruitGeneralSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
























