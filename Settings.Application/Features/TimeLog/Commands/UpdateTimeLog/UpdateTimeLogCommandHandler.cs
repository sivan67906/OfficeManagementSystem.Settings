using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TimeLogs.Commands.UpdateTimeLog;

internal class UpdateTimeLogCommandHandler : IRequestHandler<UpdateTimeLogCommand>
{
    private readonly IGenericRepository<TimeLog> _timeLogRepository;

    public UpdateTimeLogCommandHandler(
        IGenericRepository<TimeLog> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;

    public async System.Threading.Tasks.Task Handle(UpdateTimeLogCommand request, CancellationToken cancellationToken)
    {
        var timeLog = new TimeLog
        {
            Id = request.Id,
            CBTimeLogJsonSettings = request.CBTimeLogJsonSettings,
            IsTimeTrackerReminderEnabled = request.IsTimeTrackerReminderEnabled,
            TLTime = request.TLTime,
            IsDailyTimeLogReportEnabled = request.IsDailyTimeLogReportEnabled,
            RoleId = request.RoleId,
            UpdatedDate = DateTime.Now
        };

        await _timeLogRepository.UpdateAsync(timeLog);
    }
}




























