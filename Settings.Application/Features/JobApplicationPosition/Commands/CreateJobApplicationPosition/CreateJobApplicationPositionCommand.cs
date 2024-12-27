using MediatR;

namespace Settings.Application.Features.JobApplicationPositions.Commands.CreateJobApplicationPosition;

public class CreateJobApplicationPositionCommand : IRequest
{
    public string? JAPositionCode { get; set; }
    public string? JAPositionName { get; set; }
}
























