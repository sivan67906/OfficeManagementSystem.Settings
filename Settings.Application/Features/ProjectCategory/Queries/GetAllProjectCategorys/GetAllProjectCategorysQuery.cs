using Settings.Application.DTOs;
using MediatR;

namespace Settings.Application.Features.ProjectCategories.Queries.GetAllProjectCategories;

public class GetAllProjectCategoriesQuery : IRequest<IEnumerable<ProjectCategoryDTO>>
{
}












