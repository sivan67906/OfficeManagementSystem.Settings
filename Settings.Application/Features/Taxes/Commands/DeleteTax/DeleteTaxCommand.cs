using MediatR;

namespace Settings.Application.Features.Taxes.Commands.DeleteTax;
public class DeleteTaxCommand : IRequest
{
    public int Id { get; set; }
}
