using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.JobApplicationPositions.Commands.DeleteJobApplicationPosition;

internal class DeleteJobApplicationPositionCommandHandler : IRequestHandler<DeleteJobApplicationPositionCommand>
{
    private readonly IGenericRepository<JobApplicationPosition> _jobApplicationPositionRepository;

    public DeleteJobApplicationPositionCommandHandler(
        IGenericRepository<JobApplicationPosition> jobApplicationPositionRepository) =>
        _jobApplicationPositionRepository = jobApplicationPositionRepository;
    public async System.Threading.Tasks.Task Handle(DeleteJobApplicationPositionCommand request, CancellationToken cancellationToken)
    {
        await _jobApplicationPositionRepository.DeleteAsync(request.Id);
    }
}
























