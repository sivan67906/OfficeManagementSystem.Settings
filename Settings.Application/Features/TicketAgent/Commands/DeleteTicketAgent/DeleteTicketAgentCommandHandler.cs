using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketAgents.Commands.DeleteTicketAgent;

internal class DeleteTicketAgentCommandHandler : IRequestHandler<DeleteTicketAgentCommand>
{
    private readonly IGenericRepository<TicketAgent> _ticketAgentRepository;

    public DeleteTicketAgentCommandHandler(
        IGenericRepository<TicketAgent> ticketAgentRepository) =>
        _ticketAgentRepository = ticketAgentRepository;
    public async System.Threading.Tasks.Task Handle(DeleteTicketAgentCommand request, CancellationToken cancellationToken)
    {
        await _ticketAgentRepository.DeleteAsync(request.Id);
    }
}














































