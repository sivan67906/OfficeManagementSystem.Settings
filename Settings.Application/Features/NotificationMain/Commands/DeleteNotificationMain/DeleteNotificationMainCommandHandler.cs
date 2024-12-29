using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.NotificationMains.Commands.DeleteNotificationMain;

internal class DeleteNotificationMainCommandHandler : IRequestHandler<DeleteNotificationMainCommand>
{
    private readonly IGenericRepository<NotificationMain> _notificationMainRepository;

    public DeleteNotificationMainCommandHandler(
        IGenericRepository<NotificationMain> notificationMainRepository) =>
        _notificationMainRepository = notificationMainRepository;
    public async System.Threading.Tasks.Task Handle(DeleteNotificationMainCommand request, CancellationToken cancellationToken)
    {
        await _notificationMainRepository.DeleteAsync(request.Id);
    }
}

































