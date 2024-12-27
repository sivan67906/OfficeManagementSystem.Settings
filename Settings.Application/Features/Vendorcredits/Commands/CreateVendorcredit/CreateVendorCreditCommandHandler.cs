using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Vendorcredits.Commands.CreateVendorcredit;
public class CreateVendorCreditCommandHandler : IRequestHandler<CreateVendorCreditCommand, int>
{
    private readonly IGenericRepository<VendorCredit> _vendorrepo;
    public CreateVendorCreditCommandHandler(IGenericRepository<VendorCredit> vendorrepo)
    {
        _vendorrepo = vendorrepo;
    }

    public async Task<int> Handle(CreateVendorCreditCommand request, CancellationToken cancellationToken)
    {
        var client = new VendorCredit
        {
            VendorCreditPrefix = request.VendorCreditPrefix,
            VendorCreditNumberSeperater = request.VendorCreditNumberSeperater,
            VendorCreditNumberDigits = request.VendorCreditNumberDigits,
            VendorCreditNumberExample = request.VendorCreditNumberExample,
        };
        await _vendorrepo.CreateAsync(client);
        return client.Id;
    }
}
