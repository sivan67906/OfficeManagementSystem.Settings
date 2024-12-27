using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Notifications.Commands.CreateNotification;

internal class CreateNotificationCommandHandler(
    IGenericRepository<Notification> notificationRepository) : IRequestHandler<CreateNotificationCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateNotificationCommand request, CancellationToken cancellationToken)
    {
        var notification = new Notification
        {
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
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await notificationRepository.CreateAsync(notification);
    }
}





























