using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TimeLogs.Commands.DeleteTimeLog;

internal class DeleteTimeLogCommandHandler : IRequestHandler<DeleteTimeLogCommand>
{
    private readonly IGenericRepository<TimeLog> _timeLogRepository;

    public DeleteTimeLogCommandHandler(
        IGenericRepository<TimeLog> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;
    public async System.Threading.Tasks.Task Handle(DeleteTimeLogCommand request, CancellationToken cancellationToken)
    {
        await _timeLogRepository.DeleteAsync(request.Id);
    }
}




























