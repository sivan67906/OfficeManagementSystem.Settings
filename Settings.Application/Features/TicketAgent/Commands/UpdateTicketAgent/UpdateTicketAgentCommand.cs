using MediatR;

namespace Settings.Application.Features.TicketAgents.Commands.UpdateTicketAgent;

public class UpdateTicketAgentCommand : IRequest
{
    public Guid Id { get; set; }
    public string? TicketAgentCode { get; set; }
    public string? TicketAgentName { get; set; }
}














































