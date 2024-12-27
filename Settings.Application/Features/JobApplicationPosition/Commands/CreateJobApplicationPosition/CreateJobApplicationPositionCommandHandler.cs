using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.JobApplicationPositions.Commands.CreateJobApplicationPosition;

internal class CreateJobApplicationPositionCommandHandler(
    IGenericRepository<JobApplicationPosition> jobApplicationPositionRepository) : IRequestHandler<CreateJobApplicationPositionCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateJobApplicationPositionCommand request, CancellationToken cancellationToken)
    {
        var jobApplicationPosition = new JobApplicationPosition
        {
            JAPositionCode = request.JAPositionCode,
            JAPositionName = request.JAPositionName,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await jobApplicationPositionRepository.CreateAsync(jobApplicationPosition);
    }
}
























