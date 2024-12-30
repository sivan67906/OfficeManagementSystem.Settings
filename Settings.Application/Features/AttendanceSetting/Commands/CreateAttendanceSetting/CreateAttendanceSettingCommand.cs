using MediatR;

namespace Settings.Application.Features.AttendanceSettings.Commands.CreateAttendanceSetting;

public class CreateAttendanceSettingCommand : IRequest
{
    public string? AttendanceSettingCode { get; set; }
    public string? AttendanceSettingName { get; set; }
}








































