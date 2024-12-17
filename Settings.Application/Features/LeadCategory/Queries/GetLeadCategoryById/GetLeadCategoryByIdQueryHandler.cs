using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Interfaces;

namespace Settings.Application.Feauters.LeadCategory.Queries.GetLeadCategoryById
{
    public class GetLeadCategoryByIdQueryHandler : IRequestHandler<GetLeadCategoryByIdQuery, LeadCategoryDTO>
    {
        private readonly IGenericRepository<Domain.Entities.LeadCategory> _leadcategoryRepository;
        public GetLeadCategoryByIdQueryHandler(IGenericRepository<Domain.Entities.LeadCategory> repository) => _leadcategoryRepository = repository;

        public async Task<LeadCategoryDTO> Handle(GetLeadCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _leadcategoryRepository.GetByIdAsync(request.Id);
            if (category == null) return null;
            return new LeadCategoryDTO
            {
                Id = category.Id,
                CategoryName = category.CategoryName,
                
            };
        }
    }
}


