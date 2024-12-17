using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Feauters.LeadAgent.Queries.GetAllLeadAgents
{
    public class GetAllLeadAgentsQuery : IRequest<IEnumerable<LeadAgentDTO>>
    {
    }
}


