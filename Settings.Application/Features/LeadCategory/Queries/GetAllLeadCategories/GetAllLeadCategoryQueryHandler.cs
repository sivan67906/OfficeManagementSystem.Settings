using MediatR;
using Settings.Domain.Interfaces;
using Settings.Domain.Responses;

namespace Settings.Application.Feauters.LeadCategory.Queries.GetAllLeadCategories
{
    public class GetAllLeadCategoryQueryHandler : IRequestHandler<GetAllLeadCategoryQuery, ServerResponse>
    {
        private readonly IGenericRepository<Domain.Entities.LeadCategory> _repository;
        public GetAllLeadCategoryQueryHandler(IGenericRepository<Domain.Entities.LeadCategory> repository) => _repository = repository;

        public async Task<ServerResponse> Handle(GetAllLeadCategoryQuery request, CancellationToken cancellationToken)
        {
            return new ServerResponse(Message: "Not Implemented");
        }

        //public async Task<IEnumerable<LeadCategoryDTO>> Handle(GetAllLeadCategoryQuery request, CancellationToken cancellationToken)
        //{
        //    var categorys = await _repository.GetAllAsync();

        //    var categorylist = categorys.Select(x => new LeadCategoryDTO
        //    {
        //        Id = x.Id,
        //        CategoryName = x.CategoryName

        //    }).ToList();

        //    return categorylist;
        //}
    }
}


