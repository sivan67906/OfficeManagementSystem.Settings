using MediatR;
using Settings.Domain.Interfaces;
using Settings.Domain.Responses;

namespace Settings.Application.Feauters.LeadCategory.Commands.DeleteLeadCategory
{
    public class DeleteLeadCategoryCommandHandler : IRequestHandler<DeleteLeadCategoryCommand, ServerResponse>
    {
        private readonly IGenericRepository<Domain.Entities.LeadCategory> _repository;
        public DeleteLeadCategoryCommandHandler(IGenericRepository<Domain.Entities.LeadCategory> repository) => _repository = repository;

        public async Task<ServerResponse> Handle(DeleteLeadCategoryCommand request, CancellationToken cancellationToken)
        {
            return new ServerResponse(Message: "Not Implemented");
        }

        //public async System.Threading.Tasks.Task Handle(DeleteLeadCategoryCommand request, CancellationToken cancellationToken)
        //{
        //    if (request == null || request.Id == null)
        //    {
        //        throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
        //    }

        //    await _repository.DeleteAsync(request.Id);
        //}
    }
}


