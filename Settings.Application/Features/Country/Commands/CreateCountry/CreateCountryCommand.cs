using MediatR;

namespace Settings.Application.Features.Countries.Commands.CreateCountry;

public class CreateCountryCommand : IRequest
{
    public string? Code { get; set; }
    public required string Name { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;
}













