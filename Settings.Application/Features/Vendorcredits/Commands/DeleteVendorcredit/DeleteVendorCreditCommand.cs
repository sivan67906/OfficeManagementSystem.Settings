using MediatR;

namespace Settings.Application.Features.Vendorcredits.Commands.DeleteVendorcredit;
public class DeleteVendorCreditCommand : IRequest
{
    public int Id { get; set; }
}
