using MediatR;
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
            return new ServerResponse(Message: "Not Implemented");
        }

        //public async Task<LeadCategoryDTO> Handle(GetLeadCategoryByIdQuery request, CancellationToken cancellationToken)
        //{
        //    var category = await _leadcategoryRepository.GetByIdAsync(request.Id);
        //    if (category == null) return null;
        //    return new LeadCategoryDTO
        //    {
        //        Id = category.Id,
        //        CategoryName = category.CategoryName,

        //    };
        //}
    }
}


