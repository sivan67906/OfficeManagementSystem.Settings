using MediatR;
using Settings.Domain.Interfaces;

namespace Settings.Application.Feauters.LeadAgent.Commands.DeleteLeadAgent
{
    public class DeleteLeadAgentCommandHandler : IRequestHandler<DeleteLeadAgentCommand>
    {
        private readonly IGenericRepository<Domain.Entities.LeadAgent> _repository;
        public DeleteLeadAgentCommandHandler(IGenericRepository<Domain.Entities.LeadAgent> repository) => _repository = repository;

        public async System.Threading.Tasks.Task Handle(DeleteLeadAgentCommand request, CancellationToken cancellationToken)
        {
            if (request == null || request.Id == null)
            {
                throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
            }

            await _repository.DeleteAsync(request.Id);
        }
    }
}


