using MediatR;

namespace Settings.Application.Features.Notifications.Commands.DeleteNotification
{
    public class DeleteNotificationCommand : IRequest
    {
        public int Id { get; set; }
    }
}





























