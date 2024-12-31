using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.FinanceInvoiceSettings.Commands.CreateFinanceInvoiceSetting;

internal class CreateFinanceInvoiceSettingCommandHandler(
    IGenericRepository<FinanceInvoiceSetting> financeInvoiceSettingRepository) : IRequestHandler<CreateFinanceInvoiceSettingCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateFinanceInvoiceSettingCommand request, CancellationToken cancellationToken)
    {
        var financeInvoiceSetting = new FinanceInvoiceSetting
        {
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
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await financeInvoiceSettingRepository.CreateAsync(financeInvoiceSetting);
    }
}












































