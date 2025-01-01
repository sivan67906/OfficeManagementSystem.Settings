using MediatR;

namespace Settings.Application.Features.Taxes.Commands.CreateTax;
public class CreateTaxCommand : IRequest<Guid>
{
    public string? Name { get; set; }
    public float Rate { get; set; }
}
