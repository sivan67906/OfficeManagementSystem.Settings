using MediatR;

namespace Settings.Application.Features.Cities.Commands.UpdateCity;

public class UpdateCityCommand : IRequest
{
    public Guid Id { get; set; }
    public string? Code { get; set; }
    public required string Name { get; set; }
    public Guid StateId { get; set; }
    public DateTime UpdatedDate { get; set; }
}

















