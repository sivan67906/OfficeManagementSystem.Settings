using MediatR;
using Settings.Application.DTOs;
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
            var categories = await _repository.GetAllAsync();
            if (!categories.Any()) return new ServerResponse(IsSuccess: false, Message: "No Lead Category there");

            var categorylist = categories.Select(x => new GetLeadCategory
            {
                Id = x.Id,
                CategoryName = x.CategoryName!
            }).ToList();

            return new ServerResponse(IsSuccess: true, Message: "GetAll Lead Categories Executed", Data: categorylist);
        }
    }
}


