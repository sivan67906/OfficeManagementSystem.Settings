using MediatR;
using Settings.Domain.Interfaces;

namespace Settings.Application.Feauters.LeadAgent.Commands.UpdateLeadAgent
{
    public class UpdateLeadAgentCommandHandler : IRequestHandler<UpdateLeadAgentCommand, Guid>
    {
        private readonly IGenericRepository<Domain.Entities.LeadAgent> _repository;
        public UpdateLeadAgentCommandHandler(IGenericRepository<Domain.Entities.LeadAgent> repository) => _repository = repository;

        public async Task<Guid> Handle(UpdateLeadAgentCommand request, CancellationToken cancellationToken)
        {
            var leadAgent = new Domain.Entities.LeadAgent
            {
                Id = request.Id,
                AgentName = request.AgentName,
            };
            await _repository.UpdateAsync(leadAgent);
            return request.Id;
        }
    }
}


