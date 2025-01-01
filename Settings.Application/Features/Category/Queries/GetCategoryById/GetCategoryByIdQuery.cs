using Settings.Application.DTOs;
using MediatR;

namespace Settings.Application.Features.Categories.Queries.GetCategoryById
{
    public class GetCategoryByIdQuery : IRequest<CategoryDTO>
    {
        public Guid Id { get; set; }
    }
}









