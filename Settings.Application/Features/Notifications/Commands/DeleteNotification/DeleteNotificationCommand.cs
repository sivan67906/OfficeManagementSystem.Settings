using MediatR;

namespace Settings.Application.Features.Notifications.Commands.DeleteNotification;
public class DeleteNotificationCommand : IRequest
{
    public Guid Id { get; set; }
}
