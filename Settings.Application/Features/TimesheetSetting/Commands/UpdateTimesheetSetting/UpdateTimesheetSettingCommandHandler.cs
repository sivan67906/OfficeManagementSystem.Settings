using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TimesheetSettings.Commands.UpdateTimesheetSetting;

internal class UpdateTimesheetSettingCommandHandler : IRequestHandler<UpdateTimesheetSettingCommand>
{
    private readonly IGenericRepository<TimesheetSetting> _timesheetSettingRepository;

    public UpdateTimesheetSettingCommandHandler(
        IGenericRepository<TimesheetSetting> timesheetSettingRepository) =>
        _timesheetSettingRepository = timesheetSettingRepository;

    public async System.Threading.Tasks.Task Handle(UpdateTimesheetSettingCommand request, CancellationToken cancellationToken)
    {
        var timesheetSetting = new TimesheetSetting
        {
            Id = request.Id,
            TimesheetSettingCode = request.TimesheetSettingCode,
            TimesheetSettingName = request.TimesheetSettingName,
            UpdatedDate = DateTime.Now
        };

        await _timesheetSettingRepository.UpdateAsync(timesheetSetting);
    }
}




































