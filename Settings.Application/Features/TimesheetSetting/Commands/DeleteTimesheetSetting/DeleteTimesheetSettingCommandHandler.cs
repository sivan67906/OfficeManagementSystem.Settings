using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TimesheetSettings.Commands.DeleteTimesheetSetting;

internal class DeleteTimesheetSettingCommandHandler : IRequestHandler<DeleteTimesheetSettingCommand>
{
    private readonly IGenericRepository<TimesheetSetting> _timeLogRepository;

    public DeleteTimesheetSettingCommandHandler(
        IGenericRepository<TimesheetSetting> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;
    public async System.Threading.Tasks.Task Handle(DeleteTimesheetSettingCommand request, CancellationToken cancellationToken)
    {
        await _timeLogRepository.DeleteAsync(request.Id);
    }
}




































