using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Notifications.Queries.GetAllNotifications;

internal class GetAllNotificationsQueryHandler : IRequestHandler<GetAllNotificationsQuery, IEnumerable<NotificationDTO>>
{
    private readonly IGenericRepository<Notification> _notificationRepository;
    private readonly IGenericRepository<ProjectReminderPerson> _projectReminderPersonRepository;

    public GetAllNotificationsQueryHandler(
        IGenericRepository<Notification> notificationRepository,
        IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository)
    {
        _notificationRepository = notificationRepository;
        _projectReminderPersonRepository = projectReminderPersonRepository;
    }

    public async Task<IEnumerable<NotificationDTO>> Handle(GetAllNotificationsQuery request, CancellationToken cancellationToken)
    {
        var notifications = await _notificationRepository.GetAllAsync();
        var notificationList = notifications.Select(x => new NotificationDTO
        {
            Id = x.Id,
            CommonNotificationJson = x.CommonNotificationJson,
            LeaveNotificationJson = x.LeaveNotificationJson,
            ProposalNotificationJson = x.ProposalNotificationJson,
            InvoiceNotificationJson = x.InvoiceNotificationJson,
            PaymentNotificationJson = x.PaymentNotificationJson,
            TaskNotificationJson = x.TaskNotificationJson,
            TicketNotificationJson = x.TicketNotificationJson,
            ProjectNotificationJson = x.ProjectNotificationJson,
            ReminderNotificationJson = x.ReminderNotificationJson,
            RequestNotificationJson = x.RequestNotificationJson
        }).ToList();

        return notificationList;
    }
}





























