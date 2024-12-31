using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;
namespace Settings.Application.Features.NotificationMains.Queries.GetAllNotificationMain;

internal class GetAllNotificationMainQueryHandler : IRequestHandler<GetAllNotificationMainQuery, IEnumerable<NotificationMainDTO>>
{
    private readonly IGenericRepository<NotificationMain> _notificationMainRepository;

    public GetAllNotificationMainQueryHandler(
        IGenericRepository<NotificationMain> notificationMainRepository)
    {
        _notificationMainRepository = notificationMainRepository;
    }

    public async Task<IEnumerable<NotificationMainDTO>> Handle(GetAllNotificationMainQuery request, CancellationToken cancellationToken)
    {
        var notificationMain = await _notificationMainRepository.GetAllAsync();
        var notificationMainList = notificationMain.Select(x => new NotificationMainDTO
        {
            Id = x.Id,
            CommonNotificationMainJson = x.CommonNotificationJson,
            LeaveNotificationMainJson = x.LeaveNotificationJson,
            ProposalNotificationMainJson = x.ProposalNotificationJson,
            InvoiceNotificationMainJson = x.InvoiceNotificationJson,
            PaymentNotificationMainJson = x.PaymentNotificationJson,
            TaskNotificationMainJson = x.TaskNotificationJson,
            TicketNotificationMainJson = x.TicketNotificationJson,
            ProjectNotificationMainJson = x.ProjectNotificationJson,
            ReminderNotificationMainJson = x.ReminderNotificationJson,
            RequestNotificationMainJson = x.RequestNotificationJson
        }).ToList();

        return notificationMainList;
    }
}

































