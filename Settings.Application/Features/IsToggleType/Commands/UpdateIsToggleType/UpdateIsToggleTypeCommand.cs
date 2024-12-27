using MediatR;

namespace Settings.Application.Features.IsToggleTypes.Commands.UpdateIsToggleType;

public class UpdateIsToggleTypeCommand : IRequest
{
    public int Id { get; set; }
    public string? CQTypeCode { get; set; }
    public string? CQTypeName { get; set; }
}




























