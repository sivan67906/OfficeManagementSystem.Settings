using MediatR;

namespace Settings.Application.Features.RecruiterSettings.Commands.DeleteRecruiterSetting
{
    public class DeleteRecruiterSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
























