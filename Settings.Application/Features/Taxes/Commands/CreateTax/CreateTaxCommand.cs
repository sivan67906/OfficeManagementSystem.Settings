using MediatR;

namespace Settings.Application.Features.Taxes.Commands.CreateTax;
public class CreateTaxCommand : IRequest<int>
{
    public string? Name { get; set; }
    public float Rate { get; set; }
}
