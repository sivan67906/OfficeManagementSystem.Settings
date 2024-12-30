using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.AttendanceSettings.Queries.GetAttendanceSettingById;

internal class GetAttendanceSettingByIdQueryHandler : IRequestHandler<GetAttendanceSettingByIdQuery, AttendanceSettingDTO>
{
    private readonly IGenericRepository<AttendanceSetting> _attendanceSettingRepository;

    public GetAttendanceSettingByIdQueryHandler(
        IGenericRepository<AttendanceSetting> attendanceSettingRepository) =>
        _attendanceSettingRepository = attendanceSettingRepository;

    public async Task<AttendanceSettingDTO> Handle(GetAttendanceSettingByIdQuery request, CancellationToken cancellationToken)
    {
        var attendanceSetting = await _attendanceSettingRepository.GetByIdAsync(request.Id);
        if (attendanceSetting == null) return null;
        return new AttendanceSettingDTO
        {
            Id = attendanceSetting.Id,
            AttendanceSettingCode = attendanceSetting.AttendanceSettingCode,
            AttendanceSettingName = attendanceSetting.AttendanceSettingName
        };
    }
}








































