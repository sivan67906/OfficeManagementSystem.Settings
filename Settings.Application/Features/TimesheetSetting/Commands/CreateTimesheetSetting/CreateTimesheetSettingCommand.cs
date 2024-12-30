using MediatR;

namespace Settings.Application.Features.TimesheetSettings.Commands.CreateTimesheetSetting;

public class CreateTimesheetSettingCommand : IRequest
{
    public string? TimesheetSettingCode { get; set; }
    public string? TimesheetSettingName { get; set; }
}




































