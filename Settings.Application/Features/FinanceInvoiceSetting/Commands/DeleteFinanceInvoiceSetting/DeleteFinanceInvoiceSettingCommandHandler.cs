using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.FinanceInvoiceSettings.Commands.DeleteFinanceInvoiceSetting;

internal class DeleteFinanceInvoiceSettingCommandHandler : IRequestHandler<DeleteFinanceInvoiceSettingCommand>
{
    private readonly IGenericRepository<FinanceInvoiceSetting> _timeLogRepository;

    public DeleteFinanceInvoiceSettingCommandHandler(
        IGenericRepository<FinanceInvoiceSetting> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;
    public async System.Threading.Tasks.Task Handle(DeleteFinanceInvoiceSettingCommand request, CancellationToken cancellationToken)
    {
        await _timeLogRepository.DeleteAsync(request.Id);
    }
}












































