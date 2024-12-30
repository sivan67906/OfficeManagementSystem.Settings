using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketAgents.Commands.DeleteTicketAgent;

internal class DeleteTicketAgentCommandHandler : IRequestHandler<DeleteTicketAgentCommand>
{
    private readonly IGenericRepository<TicketAgent> _timeLogRepository;

    public DeleteTicketAgentCommandHandler(
        IGenericRepository<TicketAgent> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;
    public async System.Threading.Tasks.Task Handle(DeleteTicketAgentCommand request, CancellationToken cancellationToken)
    {
        await _timeLogRepository.DeleteAsync(request.Id);
    }
}








































