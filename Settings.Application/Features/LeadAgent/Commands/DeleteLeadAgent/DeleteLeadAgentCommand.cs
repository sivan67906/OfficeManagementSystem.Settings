using MediatR;

namespace Settings.Application.Feauters.LeadAgent.Commands.DeleteLeadAgent
{
    public class DeleteLeadAgentCommand : IRequest
    {
        public int Id { get; set; }
    }
}


