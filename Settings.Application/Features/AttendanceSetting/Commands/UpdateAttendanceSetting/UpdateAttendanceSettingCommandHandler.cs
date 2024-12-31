using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.AttendanceSettings.Commands.UpdateAttendanceSetting;

internal class UpdateAttendanceSettingCommandHandler : IRequestHandler<UpdateAttendanceSettingCommand>
{
    private readonly IGenericRepository<AttendanceSetting> _attendanceSettingRepository;

    public UpdateAttendanceSettingCommandHandler(
        IGenericRepository<AttendanceSetting> attendanceSettingRepository) =>
        _attendanceSettingRepository = attendanceSettingRepository;

    public async System.Threading.Tasks.Task Handle(UpdateAttendanceSettingCommand request, CancellationToken cancellationToken)
    {
        var attendanceSetting = new AttendanceSetting
        {
            Id = request.Id,
            AttendanceSettingCode = request.AttendanceSettingCode,
            AttendanceSettingName = request.AttendanceSettingName,
            UpdatedDate = DateTime.Now
        };

        await _attendanceSettingRepository.UpdateAsync(attendanceSetting);
    }
}








































