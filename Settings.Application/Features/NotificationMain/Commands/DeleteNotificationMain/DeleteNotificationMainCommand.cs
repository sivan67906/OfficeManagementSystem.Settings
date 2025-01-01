using MediatR;

namespace Settings.Application.Features.NotificationMains.Commands.DeleteNotificationMain
{
    public class DeleteNotificationMainCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}

































