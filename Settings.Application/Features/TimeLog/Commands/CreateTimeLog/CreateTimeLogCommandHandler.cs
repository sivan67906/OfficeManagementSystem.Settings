using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TimeLogs.Commands.CreateTimeLog;

internal class CreateTimeLogCommandHandler(
    IGenericRepository<TimeLog> timeLogRepository) : IRequestHandler<CreateTimeLogCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateTimeLogCommand request, CancellationToken cancellationToken)
    {
        var timeLog = new TimeLog
        {
            CBTimeLogJsonSettings = request.CBTimeLogJsonSettings,
            IsTimeTrackerReminderEnabled = request.IsTimeTrackerReminderEnabled,
            TLTime = request.TLTime,
            IsDailyTimeLogReportEnabled = request.IsDailyTimeLogReportEnabled,
            RoleId = request.RoleId,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await timeLogRepository.CreateAsync(timeLog);
    }
}




























