using MediatR;

namespace Settings.Application.Features.Cities.Commands.CreateCity;

public class CreateCityCommand : IRequest
{
    public string? Code { get; set; }
    public required string Name { get; set; }
    public Guid StateId { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;
}

















