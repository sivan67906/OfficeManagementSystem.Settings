using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.FinanceUnitSettings.Commands.DeleteFinanceUnitSetting;

internal class DeleteFinanceUnitSettingCommandHandler : IRequestHandler<DeleteFinanceUnitSettingCommand>
{
    private readonly IGenericRepository<FinanceUnitSetting> _timeLogRepository;

    public DeleteFinanceUnitSettingCommandHandler(
        IGenericRepository<FinanceUnitSetting> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;
    public async System.Threading.Tasks.Task Handle(DeleteFinanceUnitSettingCommand request, CancellationToken cancellationToken)
    {
        await _timeLogRepository.DeleteAsync(request.Id);
    }
}
































