using MediatR;

namespace Settings.Application.Features.JobApplicationPositions.Commands.UpdateJobApplicationPosition;

public class UpdateJobApplicationPositionCommand : IRequest
{
    public Guid Id { get; set; }
    public string? JAPositionCode { get; set; }
    public string? JAPositionName { get; set; }
}
























