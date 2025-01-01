//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.CustomQuestionCategories.Queries.GetCustomQuestionCategoryById
{
    public class GetCustomQuestionCategoryByIdQuery : IRequest<CustomQuestionCategoryDTO>
    {
        public Guid Id { get; set; }
    }
}
























