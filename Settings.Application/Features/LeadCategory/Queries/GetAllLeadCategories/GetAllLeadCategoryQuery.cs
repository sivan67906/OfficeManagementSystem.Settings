using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Feauters.LeadCategory.Queries.GetAllLeadCategories
{
    public class GetAllLeadCategoryQuery : IRequest<IEnumerable<LeadCategoryDTO>>
    {
    }
}


