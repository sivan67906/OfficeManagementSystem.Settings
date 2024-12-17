using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Interfaces;

namespace Settings.Application.Feauters.LeadAgent.Queries.GetLeadAgentById
{
    public class GetLeadAgentsByIdQueryHandler : IRequestHandler<GetLeadAgentsByIdQuery, LeadAgentDTO>
    {
        private readonly IGenericRepository<Domain.Entities.LeadAgent> _leadAgentRepository;
        public GetLeadAgentsByIdQueryHandler(IGenericRepository<Domain.Entities.LeadAgent> leadAgentRepository) => _leadAgentRepository = leadAgentRepository;
        public async Task<LeadAgentDTO> Handle(GetLeadAgentsByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _leadAgentRepository.GetByIdAsync(request.Id);
            if (product == null) return null;
            return new LeadAgentDTO
            {
                Id = product.Id,
                AgentName = product.AgentName,
            };
        }
    }
}


