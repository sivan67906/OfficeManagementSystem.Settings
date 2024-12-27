using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Notifications.Commands.DeleteNotification;

internal class DeleteNotificationCommandHandler : IRequestHandler<DeleteNotificationCommand>
{
    private readonly IGenericRepository<Notification> _notificationRepository;

    public DeleteNotificationCommandHandler(
        IGenericRepository<Notification> notificationRepository) =>
        _notificationRepository = notificationRepository;
    public async System.Threading.Tasks.Task Handle(DeleteNotificationCommand request, CancellationToken cancellationToken)
    {
        await _notificationRepository.DeleteAsync(request.Id);
    }
}





























