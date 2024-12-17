using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Feauters.LeadAgent.Queries.GetLeadAgentById
{
    public class GetLeadAgentsByIdQuery : IRequest<LeadAgentDTO>
    {
        public int Id { get; set; }
    }
}


