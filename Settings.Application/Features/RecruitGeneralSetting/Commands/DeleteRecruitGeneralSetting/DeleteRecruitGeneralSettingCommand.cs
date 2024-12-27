using MediatR;

namespace Settings.Application.Features.RecruitGeneralSettings.Commands.DeleteRecruitGeneralSetting
{
    public class DeleteRecruitGeneralSettingCommand : IRequest
    {
        public int Id { get; set; }
    }
}
























