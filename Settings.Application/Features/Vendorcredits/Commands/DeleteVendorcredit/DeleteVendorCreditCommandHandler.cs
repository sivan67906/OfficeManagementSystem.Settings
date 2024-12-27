using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Vendorcredits.Commands.DeleteVendorcredit;
public class DeleteVendorCreditCommandHandler : IRequestHandler<DeleteVendorCreditCommand>
{
    private readonly IGenericRepository<VendorCredit> _vendorrepo;
    public DeleteVendorCreditCommandHandler(IGenericRepository<VendorCredit> vendorrepo)
    {
        _vendorrepo = vendorrepo;
    }

    public async System.Threading.Tasks.Task Handle(DeleteVendorCreditCommand request, CancellationToken cancellationToken)
    {
        if (request == null || request.Id == null)
        {
            throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
        }

        await _vendorrepo.DeleteAsync(request.Id);
    }
}
