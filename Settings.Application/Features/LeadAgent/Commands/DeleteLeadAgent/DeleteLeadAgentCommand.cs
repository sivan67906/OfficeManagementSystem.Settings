using MediatR;

namespace Settings.Application.Feauters.LeadAgent.Commands.DeleteLeadAgent
{
    public class DeleteLeadAgentCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}


