using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Notifications.Queries.GetByIdNotificaton;
public class GetNotificationByIdQuery : IRequest<NotificationDTO>
{
    public int Id { get; set; }
}
