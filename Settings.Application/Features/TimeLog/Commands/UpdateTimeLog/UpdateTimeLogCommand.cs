using MediatR;

namespace Settings.Application.Features.TimeLogs.Commands.UpdateTimeLog;

public class UpdateTimeLogCommand : IRequest
{
    public int Id { get; set; }
    public string? CBTimeLogJsonSettings { get; set; }
    public bool IsTimeTrackerReminderEnabled { get; set; }
    public string? TLTime { get; set; }
    public bool IsDailyTimeLogReportEnabled { get; set; }
    public int RoleId { get; set; }
}




























