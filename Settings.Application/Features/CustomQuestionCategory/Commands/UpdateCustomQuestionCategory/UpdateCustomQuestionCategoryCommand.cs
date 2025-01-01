using MediatR;

namespace Settings.Application.Features.CustomQuestionCategories.Commands.UpdateCustomQuestionCategory;

public class UpdateCustomQuestionCategoryCommand : IRequest
{
    public Guid Id { get; set; }
    public string? CQCategoryCode { get; set; }
    public string? CQCategoryName { get; set; }
}
























