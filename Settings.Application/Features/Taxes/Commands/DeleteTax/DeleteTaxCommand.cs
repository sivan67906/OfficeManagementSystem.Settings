using MediatR;

namespace Settings.Application.Features.Taxes.Commands.DeleteTax;
public class DeleteTaxCommand : IRequest
{
    public Guid Id { get; set; }
}
