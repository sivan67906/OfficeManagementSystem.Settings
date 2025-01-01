using MediatR;

namespace Settings.Application.Features.CustomQuestionCategories.Commands.DeleteCustomQuestionCategory
{
    public class DeleteCustomQuestionCategoryCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
























