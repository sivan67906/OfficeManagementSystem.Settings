//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.AttendanceSettings.Queries.GetAttendanceSettingById
{
    public class GetAttendanceSettingByIdQuery : IRequest<AttendanceSettingDTO>
    {
        public int Id { get; set; }
    }
}








































