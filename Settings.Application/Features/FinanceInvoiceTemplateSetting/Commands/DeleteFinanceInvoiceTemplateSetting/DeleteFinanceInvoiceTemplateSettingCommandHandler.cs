using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.FinanceInvoiceTemplateSettings.Commands.DeleteFinanceInvoiceTemplateSetting;

internal class DeleteFinanceInvoiceTemplateSettingCommandHandler : IRequestHandler<DeleteFinanceInvoiceTemplateSettingCommand>
{
    private readonly IGenericRepository<FinanceInvoiceTemplateSetting> _timeLogRepository;

    public DeleteFinanceInvoiceTemplateSettingCommandHandler(
        IGenericRepository<FinanceInvoiceTemplateSetting> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;
    public async System.Threading.Tasks.Task Handle(DeleteFinanceInvoiceTemplateSettingCommand request, CancellationToken cancellationToken)
    {
        await _timeLogRepository.DeleteAsync(request.Id);
    }
}








































