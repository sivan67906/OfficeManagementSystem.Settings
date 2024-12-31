using MediatR;

namespace Settings.Application.Features.TimesheetSettings.Commands.DeleteTimesheetSetting
{
    public class DeleteTimesheetSettingCommand : IRequest
    {
        public int Id { get; set; }
    }
}




































