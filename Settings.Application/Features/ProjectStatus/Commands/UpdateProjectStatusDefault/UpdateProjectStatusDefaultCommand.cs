using MediatR;

namespace Settings.Application.Features.ProjectStatus.Commands.UpdateProjectStatusDefault;
public class UpdateProjectStatusDefaultCommand : IRequest
{
    public int Id { get; set; }
}
