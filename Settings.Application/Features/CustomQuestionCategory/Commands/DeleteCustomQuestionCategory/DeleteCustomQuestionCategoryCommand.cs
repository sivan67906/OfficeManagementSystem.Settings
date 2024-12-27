using MediatR;

namespace Settings.Application.Features.CustomQuestionCategories.Commands.DeleteCustomQuestionCategory
{
    public class DeleteCustomQuestionCategoryCommand : IRequest
    {
        public int Id { get; set; }
    }
}
























