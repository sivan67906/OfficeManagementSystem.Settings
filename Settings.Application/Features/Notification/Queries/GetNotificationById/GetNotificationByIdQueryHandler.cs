using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Notifications.Queries.GetNotificationById;

internal class GetNotificationByIdQueryHandler : IRequestHandler<GetNotificationByIdQuery, NotificationDTO>
{
    private readonly IGenericRepository<Notification> _notificationRepository;

    public GetNotificationByIdQueryHandler(
        IGenericRepository<Notification> notificationRepository) =>
        _notificationRepository = notificationRepository;

    public async Task<NotificationDTO> Handle(GetNotificationByIdQuery request, CancellationToken cancellationToken)
    {
        var notification = await _notificationRepository.GetByIdAsync(request.Id);
        if (notification == null) return null;
        return new NotificationDTO
        {
            Id = notification.Id,
            CommonNotificationJson = notification.CommonNotificationJson,
            LeaveNotificationJson = notification.LeaveNotificationJson,
            ProposalNotificationJson = notification.ProposalNotificationJson,
            InvoiceNotificationJson = notification.InvoiceNotificationJson,
            PaymentNotificationJson = notification.PaymentNotificationJson,
            TaskNotificationJson = notification.TaskNotificationJson,
            TicketNotificationJson = notification.TicketNotificationJson,
            ProjectNotificationJson = notification.ProjectNotificationJson,
            ReminderNotificationJson = notification.ReminderNotificationJson,
            RequestNotificationJson = notification.RequestNotificationJson
        };
    }
}





























