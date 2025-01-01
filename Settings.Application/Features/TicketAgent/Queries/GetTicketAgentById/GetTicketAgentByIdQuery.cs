//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.TicketAgents.Queries.GetTicketAgentById
{
    public class GetTicketAgentByIdQuery : IRequest<TicketAgentDTO>
    {
        public Guid Id { get; set; }
    }
}














































