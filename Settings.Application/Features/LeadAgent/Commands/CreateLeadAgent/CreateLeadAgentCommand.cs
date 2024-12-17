using MediatR;

namespace Settings.Application.Feauters.LeadAgent.Commands.CreateLeadAgent
{
    public class CreateLeadAgentCommand : IRequest<int>
    {
        public string? AgentName { get; set; }
    }
}


