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
            var category = await _repository.GetByIdAsync(request.Id);
            if (category == null) return new ServerResponse(Message: "No Lead Category mapped with this Id");
            await _repository.DeleteAsync(request.Id);
            return new ServerResponse(IsSuccess: true, Message: "Deleted Successfully");
        }
    }
}


