using MediatR;

namespace Settings.Application.Features.TimesheetSettings.Commands.DeleteTimesheetSetting
{
    public class DeleteTimesheetSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}




































