using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketAgents.Queries.GetTicketAgentById;

internal class GetTicketAgentByIdQueryHandler : IRequestHandler<GetTicketAgentByIdQuery, TicketAgentDTO>
{
    private readonly IGenericRepository<TicketAgent> _ticketAgentRepository;

    public GetTicketAgentByIdQueryHandler(
        IGenericRepository<TicketAgent> ticketAgentRepository) =>
        _ticketAgentRepository = ticketAgentRepository;

    public async Task<TicketAgentDTO> Handle(GetTicketAgentByIdQuery request, CancellationToken cancellationToken)
    {
        var ticketAgent = await _ticketAgentRepository.GetByIdAsync(request.Id);
        if (ticketAgent == null) return null;
        return new TicketAgentDTO
        {
            Id = ticketAgent.Id,
            TicketAgentCode = ticketAgent.TicketAgentCode,
            TicketAgentName = ticketAgent.TicketAgentName
        };
    }
}














































