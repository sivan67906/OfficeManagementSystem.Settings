using MediatR;

namespace Settings.Application.Features.ProjectSettings.Commands.DeleteProjectSetting
{
    public class DeleteProjectSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}




















