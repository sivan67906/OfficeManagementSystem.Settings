using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.FinancePrefixSettings.Commands.DeleteFinancePrefixSetting;

internal class DeleteFinancePrefixSettingCommandHandler : IRequestHandler<DeleteFinancePrefixSettingCommand>
{
    private readonly IGenericRepository<FinancePrefixSetting> _timeLogRepository;

    public DeleteFinancePrefixSettingCommandHandler(
        IGenericRepository<FinancePrefixSetting> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;
    public async System.Threading.Tasks.Task Handle(DeleteFinancePrefixSettingCommand request, CancellationToken cancellationToken)
    {
        await _timeLogRepository.DeleteAsync(request.Id);
    }
}




































