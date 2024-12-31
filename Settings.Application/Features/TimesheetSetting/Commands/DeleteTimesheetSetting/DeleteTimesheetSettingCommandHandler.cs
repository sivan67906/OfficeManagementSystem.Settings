using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TimesheetSettings.Commands.DeleteTimesheetSetting;

internal class DeleteTimesheetSettingCommandHandler : IRequestHandler<DeleteTimesheetSettingCommand>
{
    private readonly IGenericRepository<TimesheetSetting> _timeSheetSettingRepository;

    public DeleteTimesheetSettingCommandHandler(
        IGenericRepository<TimesheetSetting> timeSheetSettingRepository) =>
        _timeSheetSettingRepository = timeSheetSettingRepository;
    public async System.Threading.Tasks.Task Handle(DeleteTimesheetSettingCommand request, CancellationToken cancellationToken)
    {
        await _timeSheetSettingRepository.DeleteAsync(request.Id);
    }
}




































