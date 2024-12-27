using Settings.Application.DTOs;
using MediatR;

namespace Settings.Application.Features.Categories.Queries.GetAllCategories;

public class GetAllCategoriesQuery : IRequest<IEnumerable<CategoryDTO>>
{
}









