using MediatR;

namespace Settings.Application.Features.ProjectStatuses.Commands.DeleteProjectStatus
{
    public class DeleteProjectStatusCommand : IRequest
    {
        public int Id { get; set; }
    }
}
















