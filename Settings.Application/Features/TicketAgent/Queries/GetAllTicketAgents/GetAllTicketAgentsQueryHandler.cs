using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketAgents.Queries.GetAllTicketAgents;

internal class GetAllTicketAgentsQueryHandler : IRequestHandler<GetAllTicketAgentsQuery, IEnumerable<TicketAgentDTO>>
{
    private readonly IGenericRepository<TicketAgent> _ticketAgentRepository;

    public GetAllTicketAgentsQueryHandler(
        IGenericRepository<TicketAgent> ticketAgentRepository)
    {
        _ticketAgentRepository = ticketAgentRepository;
    }

    public async Task<IEnumerable<TicketAgentDTO>> Handle(GetAllTicketAgentsQuery request, CancellationToken cancellationToken)
    {
        var ticketAgents = await _ticketAgentRepository.GetAllAsync();
        var ticketAgentList = ticketAgents.Select(x => new TicketAgentDTO
        {
            Id = x.Id,
            TicketAgentCode = x.TicketAgentCode,
            TicketAgentName = x.TicketAgentName
        }).ToList();

        return ticketAgentList;
    }
}








































