using MediatR;

namespace Settings.Application.Features.TicketAgents.Commands.CreateTicketAgent;

public class CreateTicketAgentCommand : IRequest
{
    public string? TicketAgentCode { get; set; }
    public string? TicketAgentName { get; set; }
}














































