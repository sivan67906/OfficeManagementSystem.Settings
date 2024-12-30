using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.AttendanceSettings.Queries.GetAllAttendanceSettings;

internal class GetAllAttendanceSettingsQueryHandler : IRequestHandler<GetAllAttendanceSettingsQuery, IEnumerable<AttendanceSettingDTO>>
{
    private readonly IGenericRepository<AttendanceSetting> _attendanceSettingRepository;

    public GetAllAttendanceSettingsQueryHandler(
        IGenericRepository<AttendanceSetting> attendanceSettingRepository)
    {
        _attendanceSettingRepository = attendanceSettingRepository;
    }

    public async Task<IEnumerable<AttendanceSettingDTO>> Handle(GetAllAttendanceSettingsQuery request, CancellationToken cancellationToken)
    {
        var attendanceSettings = await _attendanceSettingRepository.GetAllAsync();
        var attendanceSettingList = attendanceSettings.Select(x => new AttendanceSettingDTO
        {
            Id = x.Id,
            AttendanceSettingCode = x.AttendanceSettingCode,
            AttendanceSettingName = x.AttendanceSettingName
        }).ToList();

        return attendanceSettingList;
    }
}








































