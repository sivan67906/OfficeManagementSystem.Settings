using MediatR;

namespace Settings.Application.Features.IsToggleTypes.Commands.CreateIsToggleType;

public class CreateIsToggleTypeCommand : IRequest
{
    public string? CQTypeCode { get; set; }
    public string? CQTypeName { get; set; }
}




























