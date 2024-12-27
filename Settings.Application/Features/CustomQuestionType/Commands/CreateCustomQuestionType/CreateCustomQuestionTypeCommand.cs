using MediatR;

namespace Settings.Application.Features.CustomQuestionTypes.Commands.CreateCustomQuestionType;

public class CreateCustomQuestionTypeCommand : IRequest
{
    public string? CQTypeCode { get; set; }
    public string? CQTypeName { get; set; }
}
























