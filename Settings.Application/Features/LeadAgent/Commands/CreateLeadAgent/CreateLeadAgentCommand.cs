using MediatR;

namespace Settings.Application.Feauters.LeadAgent.Commands.CreateLeadAgent
{
    public class CreateLeadAgentCommand : IRequest<Guid>
    {
        public string? AgentName { get; set; }
    }
}


