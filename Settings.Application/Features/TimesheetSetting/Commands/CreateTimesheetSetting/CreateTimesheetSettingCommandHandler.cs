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
            TimesheetSettingCode = request.TimesheetSettingCode,
            TimesheetSettingName = request.TimesheetSettingName,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await timesheetSettingRepository.CreateAsync(timesheetSetting);
    }
}




































