using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Notifications.Commands.UpdateNotification;

internal class UpdateNotificationCommandHandler : IRequestHandler<UpdateNotificationCommand>
{
    private readonly IGenericRepository<Notification> _notificationRepository;

    public UpdateNotificationCommandHandler(
        IGenericRepository<Notification> notificationRepository) =>
        _notificationRepository = notificationRepository;

    public async System.Threading.Tasks.Task Handle(UpdateNotificationCommand request, CancellationToken cancellationToken)
    {
        var notification = new Notification
        {
            Id = request.Id,
            CommonNotificationJson = request.CommonNotificationJson,
            LeaveNotificationJson = request.LeaveNotificationJson,
            ProposalNotificationJson = request.ProposalNotificationJson,
            InvoiceNotificationJson = request.InvoiceNotificationJson,
            PaymentNotificationJson = request.PaymentNotificationJson,
            TaskNotificationJson = request.TaskNotificationJson,
            TicketNotificationJson = request.TicketNotificationJson,
            ProjectNotificationJson = request.ProjectNotificationJson,
            ReminderNotificationJson = request.ReminderNotificationJson,
            RequestNotificationJson = request.RequestNotificationJson,
            UpdatedDate = DateTime.Now
        };

        await _notificationRepository.UpdateAsync(notification);
    }
}





























