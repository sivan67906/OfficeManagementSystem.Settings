using MediatR;

namespace Settings.Application.Features.Taxes.Commands.UpdateTax;
public class UpdateTaxCommand : IRequest<int>
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public float Rate { get; set; }
}
