using MediatR;

namespace Settings.Application.Feauters.LeadAgent.Commands.UpdateLeadAgent
{
    public class UpdateLeadAgentCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string? AgentName { get; set; }
    }
}


