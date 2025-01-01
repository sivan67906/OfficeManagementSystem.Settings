using Settings.Application.DTOs;
using MediatR;

namespace Settings.Application.Features.ProjectCategories.Queries.GetProjectCategoryById
{
    public class GetProjectCategoryByIdQuery : IRequest<ProjectCategoryDTO>
    {
        public Guid Id { get; set; }
    }
}












