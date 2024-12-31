using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TimesheetSettings.Commands.CreateTimesheetSetting;

internal class CreateTimesheetSettingCommandHandler(
    IGenericRepository<TimesheetSetting> timesheetSettingRepository) : IRequestHandler<CreateTimesheetSettingCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateTimesheetSettingCommand request, CancellationToken cancellationToken)
    {
        var timesheetSetting = new TimesheetSetting
        {
            ProjectId = request.ProjectId,
            TaskId = request.TaskId,
            EmployeeId = request.EmployeeId,
            StartDate = request.StartDate,
            StartTime = request.StartTime,
            StartDateTime = request.StartDateTime,
            EndDate = request.EndDate,
            EndTime = request.EndTime,
            EndDateTime = request.EndDateTime,
            Memo = request.Memo,
            TotalHours = request.TotalHours,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await timesheetSettingRepository.CreateAsync(timesheetSetting);
    }
}




































