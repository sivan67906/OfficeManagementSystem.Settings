using MediatR;
using Settings.Domain.Interfaces;

namespace Settings.Application.Feauters.LeadAgent.Commands.DeleteLeadAgent
{
    public class DeleteLeadAgentCommandHandler : IRequestHandler<DeleteLeadAgentCommand, string>
    {
        private readonly IGenericRepository<Domain.Entities.LeadAgent> _repository;
        public DeleteLeadAgentCommandHandler(IGenericRepository<Domain.Entities.LeadAgent> repository) => _repository = repository;

        public async Task<string> Handle(DeleteLeadAgentCommand request, CancellationToken cancellationToken)
        {
            if (request == null || request.Id <= 0)
            {
                return "Request or Request.Id cannot be null.";
            }
            await _repository.DeleteAsync(request.Id);
            return "Deleted Successfully";
        }
    }
}


