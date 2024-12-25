using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Notifications.Queries.GetAllNotification;
public class GetAllNotificationQuery : IRequest<IEnumerable<NotificatonDTO>>
{
}
