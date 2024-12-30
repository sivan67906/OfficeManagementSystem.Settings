using MediatR;

namespace Settings.Application.Features.TimesheetSettings.Commands.UpdateTimesheetSetting;

public class UpdateTimesheetSettingCommand : IRequest
{
    public int Id { get; set; }
    public string? TimesheetSettingCode { get; set; }
    public string? TimesheetSettingName { get; set; }
}




































