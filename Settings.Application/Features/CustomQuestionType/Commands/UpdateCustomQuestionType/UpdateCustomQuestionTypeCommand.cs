using MediatR;

namespace Settings.Application.Features.CustomQuestionTypes.Commands.UpdateCustomQuestionType;

public class UpdateCustomQuestionTypeCommand : IRequest
{
    public int Id { get; set; }
    public string? CQTypeCode { get; set; }
    public string? CQTypeName { get; set; }
}
























