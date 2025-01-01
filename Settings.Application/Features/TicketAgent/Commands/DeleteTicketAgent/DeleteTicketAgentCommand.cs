using MediatR;

namespace Settings.Application.Features.TicketAgents.Commands.DeleteTicketAgent
{
    public class DeleteTicketAgentCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}














































