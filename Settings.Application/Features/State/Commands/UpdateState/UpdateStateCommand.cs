using MediatR;

namespace Settings.Application.Features.States.Commands.UpdateState;

public class UpdateStateCommand : IRequest
{
    public Guid Id { get; set; }
    public string? Code { get; set; }
    public required string Name { get; set; }
    public Guid CountryId { get; set; }
    public DateTime UpdatedDate { get; set; }
}













