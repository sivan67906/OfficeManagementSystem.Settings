using MediatR;

namespace Settings.Application.Features.AttendanceSettings.Commands.UpdateAttendanceSetting;

public class UpdateAttendanceSettingCommand : IRequest
{
    public Guid Id { get; set; }
    public string? AttendanceSettingCode { get; set; }
    public string? AttendanceSettingName { get; set; }
}








































