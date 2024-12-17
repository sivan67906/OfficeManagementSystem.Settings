using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Feauters.LeadCategory.Queries.GetLeadCategoryById
{
    public class GetLeadCategoryByIdQuery : IRequest<LeadCategoryDTO>
    {
        public int Id { get; set; }
    }
}


