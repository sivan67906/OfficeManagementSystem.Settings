using MediatR;

namespace Settings.Application.Features.JobApplicationPositions.Commands.DeleteJobApplicationPosition
{
    public class DeleteJobApplicationPositionCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
























