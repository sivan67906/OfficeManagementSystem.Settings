using MediatR;

namespace Settings.Application.Features.RecruiterSettings.Commands.DeleteRecruiterSetting
{
    public class DeleteRecruiterSettingCommand : IRequest
    {
        public int Id { get; set; }
    }
}
























