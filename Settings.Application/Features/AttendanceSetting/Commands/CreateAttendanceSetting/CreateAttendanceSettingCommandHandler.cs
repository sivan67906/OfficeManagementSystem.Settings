using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.AttendanceSettings.Commands.CreateAttendanceSetting;

internal class CreateAttendanceSettingCommandHandler(
    IGenericRepository<AttendanceSetting> attendanceSettingRepository) : IRequestHandler<CreateAttendanceSettingCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateAttendanceSettingCommand request, CancellationToken cancellationToken)
    {
        var attendanceSetting = new AttendanceSetting
        {
            AttendanceSettingCode = request.AttendanceSettingCode,
            AttendanceSettingName = request.AttendanceSettingName,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await attendanceSettingRepository.CreateAsync(attendanceSetting);
    }
}








































