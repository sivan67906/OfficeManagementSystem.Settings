using MediatR;

namespace Settings.Application.Features.ProjectSettings.Commands.DeleteProjectSetting
{
    public class DeleteProjectSettingCommand : IRequest
    {
        public int Id { get; set; }
    }
}




















