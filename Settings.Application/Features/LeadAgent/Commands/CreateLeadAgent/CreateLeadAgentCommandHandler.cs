using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Feauters.LeadAgent.Commands.CreateLeadAgent
{
    public class CreateLeadAgentCommandHandler : IRequestHandler<CreateLeadAgentCommand, Guid>
    {
        private readonly IGenericRepository<Domain.Entities.LeadAgent> _leadagentRepository;
        public CreateLeadAgentCommandHandler(IGenericRepository<Domain.Entities.LeadAgent> leadagentRepository) => _leadagentRepository = leadagentRepository;

        public async Task<Guid> Handle(CreateLeadAgentCommand request, CancellationToken cancellationToken)
        {
            var leadAgent = new Domain.Entities.LeadAgent
            {
                AgentName = request.AgentName,
                
            };

            await _leadagentRepository.CreateAsync(leadAgent);
            return leadAgent.Id;
        }
    }
}


