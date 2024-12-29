using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.NotificationMains.Commands.UpdateNotificationMain;

internal class UpdateNotificationMainCommandHandler : IRequestHandler<UpdateNotificationMainCommand>
{
    private readonly IGenericRepository<NotificationMain> _notificationMainRepository;

    public UpdateNotificationMainCommandHandler(
        IGenericRepository<NotificationMain> notificationMainRepository) =>
        _notificationMainRepository = notificationMainRepository;

    public async System.Threading.Tasks.Task Handle(UpdateNotificationMainCommand request, CancellationToken cancellationToken)
    {
        var notificationMain = new NotificationMain
        {
            Id = request.Id,
            CommonNotificationJson = request.CommonNotificationMainJson,
            LeaveNotificationJson = request.LeaveNotificationMainJson,
            ProposalNotificationJson = request.ProposalNotificationMainJson,
            InvoiceNotificationJson = request.InvoiceNotificationMainJson,
            PaymentNotificationJson = request.PaymentNotificationMainJson,
            TaskNotificationJson = request.TaskNotificationMainJson,
            TicketNotificationJson = request.TicketNotificationMainJson,
            ProjectNotificationJson = request.ProposalNotificationMainJson,
            ReminderNotificationJson = request.RequestNotificationMainJson,
            RequestNotificationJson = request.RequestNotificationMainJson,
            UpdatedDate = DateTime.Now
        };

        await _notificationMainRepository.UpdateAsync(notificationMain);
    }
}

































