using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Interfaces;
using Settings.Domain.Responses;

namespace Settings.Application.Feauters.LeadCategory.Queries.GetLeadCategoryById
{
    public class GetLeadCategoryByIdQueryHandler : IRequestHandler<GetLeadCategoryByIdQuery, ServerResponse>
    {
        private readonly IGenericRepository<Domain.Entities.LeadCategory> _leadcategoryRepository;
        public GetLeadCategoryByIdQueryHandler(IGenericRepository<Domain.Entities.LeadCategory> repository) => _leadcategoryRepository = repository;

        public async Task<ServerResponse> Handle(GetLeadCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _leadcategoryRepository.GetByIdAsync(request.Id);
            if (category == null) return new ServerResponse(IsSuccess: false, Message: "No Lead Category mapped with this Id");
            GetLeadCategory leadCategory = new GetLeadCategory
            {
                Id = category.Id,
                CategoryName = category.CategoryName!
            };
            return new ServerResponse(IsSuccess: true, Message: "GetByLead CategoryId executed", Data: leadCategory);
        }
    }
}