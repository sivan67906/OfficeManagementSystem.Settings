using MediatR;

namespace Settings.Application.Features.Vendorcredits.Commands.DeleteVendorcredit;
public class DeleteVendorCreditCommand : IRequest
{
    public Guid Id { get; set; }
}
