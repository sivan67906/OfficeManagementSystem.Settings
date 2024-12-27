using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TimeLogs.Queries.GetAllTimeLogs;

internal class GetAllTimeLogsQueryHandler : IRequestHandler<GetAllTimeLogsQuery, IEnumerable<TimeLogDTO>>
{
    private readonly IGenericRepository<TimeLog> _timeLogRepository;
    private readonly IGenericRepository<ProjectReminderPerson> _projectReminderPersonRepository;

    public GetAllTimeLogsQueryHandler(
        IGenericRepository<TimeLog> timeLogRepository,
        IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository)
    {
        _timeLogRepository = timeLogRepository;
        _projectReminderPersonRepository = projectReminderPersonRepository;
    }

    public async Task<IEnumerable<TimeLogDTO>> Handle(GetAllTimeLogsQuery request, CancellationToken cancellationToken)
    {
        var timeLogs = await _timeLogRepository.GetAllAsync();
        var timeLogList = timeLogs.Select(x => new TimeLogDTO
        {
            Id = x.Id,
            CBTimeLogJsonSettings = x.CBTimeLogJsonSettings,
            IsTimeTrackerReminderEnabled = x.IsTimeTrackerReminderEnabled,
            TLTime = x.TLTime,
            IsDailyTimeLogReportEnabled = x.IsDailyTimeLogReportEnabled,
            RoleId = x.RoleId
        }).ToList();

        return timeLogList;
    }
}




























