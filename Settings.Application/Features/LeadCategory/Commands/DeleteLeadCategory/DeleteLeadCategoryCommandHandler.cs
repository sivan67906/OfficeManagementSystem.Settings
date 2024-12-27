using MediatR;
using Settings.Domain.Interfaces;

namespace Settings.Application.Feauters.LeadCategory.Commands.DeleteLeadCategory
{
    public class DeleteLeadCategoryCommandHandler : IRequestHandler<DeleteLeadCategoryCommand>
    {
        private readonly IGenericRepository<Domain.Entities.LeadCategory> _repository;
        public DeleteLeadCategoryCommandHandler(IGenericRepository<Domain.Entities.LeadCategory> repository) => _repository = repository;

        public async System.Threading.Tasks.Task Handle(DeleteLeadCategoryCommand request, CancellationToken cancellationToken)
        {
            if (request == null || request.Id == null)
            {
                throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
            }

            await _repository.DeleteAsync(request.Id);
        }
    }
}


