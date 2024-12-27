using MediatR;

namespace Settings.Application.Features.CustomQuestionCategories.Commands.CreateCustomQuestionCategory;

public class CreateCustomQuestionCategoryCommand : IRequest
{
    public string? CQCategoryCode { get; set; }
    public string? CQCategoryName { get; set; }
}
























