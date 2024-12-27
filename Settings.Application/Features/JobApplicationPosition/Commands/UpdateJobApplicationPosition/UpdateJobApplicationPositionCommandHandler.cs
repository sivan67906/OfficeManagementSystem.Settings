using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.JobApplicationPositions.Commands.UpdateJobApplicationPosition;

internal class UpdateJobApplicationPositionCommandHandler : IRequestHandler<UpdateJobApplicationPositionCommand>
{
    private readonly IGenericRepository<JobApplicationPosition> _jobApplicationPositionRepository;

    public UpdateJobApplicationPositionCommandHandler(
        IGenericRepository<JobApplicationPosition> jobApplicationPositionRepository) =>
        _jobApplicationPositionRepository = jobApplicationPositionRepository;

    public async System.Threading.Tasks.Task Handle(UpdateJobApplicationPositionCommand request, CancellationToken cancellationToken)
    {
        var jobApplicationPosition = new JobApplicationPosition
        {
            Id = request.Id,
            JAPositionCode = request.JAPositionCode,
            JAPositionName = request.JAPositionName,
            UpdatedDate = DateTime.Now
        };

        await _jobApplicationPositionRepository.UpdateAsync(jobApplicationPosition);
    }
}
























