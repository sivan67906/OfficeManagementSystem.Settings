using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketGroups.Commands.DeleteTicketGroup;

internal class DeleteTicketGroupCommandHandler : IRequestHandler<DeleteTicketGroupCommand>
{
    private readonly IGenericRepository<TicketGroup> _timeLogRepository;

    public DeleteTicketGroupCommandHandler(
        IGenericRepository<TicketGroup> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;
    public async System.Threading.Tasks.Task Handle(DeleteTicketGroupCommand request, CancellationToken cancellationToken)
    {
        await _timeLogRepository.DeleteAsync(request.Id);
    }
}








































