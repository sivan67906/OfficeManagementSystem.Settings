using MediatR;

namespace Settings.Application.Features.NotificationMains.Commands.DeleteNotificationMain
{
    public class DeleteNotificationMainCommand : IRequest
    {
        public int Id { get; set; }
    }
}

































