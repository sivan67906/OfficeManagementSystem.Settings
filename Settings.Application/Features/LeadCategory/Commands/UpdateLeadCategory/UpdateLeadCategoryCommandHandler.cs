using MediatR;
using MediatR.Pipeline;
using Settings.Domain.Interfaces;

namespace Settings.Application.Feauters.LeadCategory.Commands.UpdateLeadCategory
{
    public class UpdateLeadCategoryCommandHandler : IRequestHandler<UpdateLeadCategoryCommand, Guid>
    {
        private readonly IGenericRepository<Domain.Entities.LeadCategory> _repository;
        public UpdateLeadCategoryCommandHandler(IGenericRepository<Domain.Entities.LeadCategory> repository) => _repository = repository;

        public async Task<Guid> Handle(UpdateLeadCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = new Domain.Entities.LeadCategory
            {
                Id = request.Id,
                CategoryName = request.CategoryName
                
            };
            await _repository.UpdateAsync(category);
            return request.Id;
        }
    }
}


