using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.FinanceInvoiceSettings.Commands.UpdateFinanceInvoiceSetting;

internal class UpdateFinanceInvoiceSettingCommandHandler : IRequestHandler<UpdateFinanceInvoiceSettingCommand>
{
    private readonly IGenericRepository<FinanceInvoiceSetting> _financeInvoiceSettingRepository;

    public UpdateFinanceInvoiceSettingCommandHandler(
        IGenericRepository<FinanceInvoiceSetting> financeInvoiceSettingRepository) =>
        _financeInvoiceSettingRepository = financeInvoiceSettingRepository;

    public async System.Threading.Tasks.Task Handle(UpdateFinanceInvoiceSettingCommand request, CancellationToken cancellationToken)
    {
        var financeInvoiceSetting = new FinanceInvoiceSetting
        {
            Id = request.Id,
            FILogoPath = request.FILogoPath,
            FILogoImageFileName = request.FILogoImageFileName,
            FIAuthorisedImagePath = request.FIAuthorisedImagePath,
            FIAuthorisedImageFileName = request.FIAuthorisedImageFileName,
            FILanguageId = request.FILanguageId,
            FIDueAfter = request.FIDueAfter,
            FISendReminderBefore = request.FISendReminderBefore,
            FISendReminderAfterEveryId = request.FISendReminderAfterEveryId,
            FISendReminderAfterEvery = request.FISendReminderAfterEvery,
            FICBGeneralJsonSettings = request.FICBGeneralJsonSettings,
            FICBClientInfoJsonSettings = request.FICBClientInfoJsonSettings,
            FITerms = request.FITerms,
            FIOtherInfo = request.FIOtherInfo,
            UpdatedDate = DateTime.Now
        };

        await _financeInvoiceSettingRepository.UpdateAsync(financeInvoiceSetting);
    }
}












































