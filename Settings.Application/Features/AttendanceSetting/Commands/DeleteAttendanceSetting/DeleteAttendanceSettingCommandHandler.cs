using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.AttendanceSettings.Commands.DeleteAttendanceSetting;

internal class DeleteAttendanceSettingCommandHandler : IRequestHandler<DeleteAttendanceSettingCommand>
{
    private readonly IGenericRepository<AttendanceSetting> _timeLogRepository;

    public DeleteAttendanceSettingCommandHandler(
        IGenericRepository<AttendanceSetting> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;
    public async System.Threading.Tasks.Task Handle(DeleteAttendanceSettingCommand request, CancellationToken cancellationToken)
    {
        await _timeLogRepository.DeleteAsync(request.Id);
    }
}








































