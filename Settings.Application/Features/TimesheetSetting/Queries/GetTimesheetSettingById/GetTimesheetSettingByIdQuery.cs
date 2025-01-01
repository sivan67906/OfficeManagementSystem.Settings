//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.TimesheetSettings.Queries.GetTimesheetSettingById
{
    public class GetTimesheetSettingByIdQuery : IRequest<TimesheetSettingDTO>
    {
        public Guid Id { get; set; }
    }
}




































