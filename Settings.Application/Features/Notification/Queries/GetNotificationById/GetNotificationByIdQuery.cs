//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Notifications.Queries.GetNotificationById
{
    public class GetNotificationByIdQuery : IRequest<NotificationDTO>
    {
        public int Id { get; set; }
    }
}





























