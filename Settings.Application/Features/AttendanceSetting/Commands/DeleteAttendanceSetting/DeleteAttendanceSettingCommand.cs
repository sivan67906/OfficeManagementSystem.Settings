using MediatR;

namespace Settings.Application.Features.AttendanceSettings.Commands.DeleteAttendanceSetting
{
    public class DeleteAttendanceSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}








































