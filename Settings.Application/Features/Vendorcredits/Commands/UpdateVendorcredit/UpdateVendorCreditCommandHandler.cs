using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Vendorcredits.Commands.UpdateVendorcredit;
public class UpdateVendorCreditCommandHandler : IRequestHandler<UpdateVendorCreditCommand, int>
{
    private readonly IGenericRepository<VendorCredit> _repository;
    public UpdateVendorCreditCommandHandler(IGenericRepository<VendorCredit> repository)
    {
        _repository = repository;
    }

    public async Task<int> Handle(UpdateVendorCreditCommand request, CancellationToken cancellationToken)
    {
        var vendor = new VendorCredit
        {
            Id = request.Id,
            VendorCreditPrefix = request.VendorCreditPrefix,
            VendorCreditNumberSeperater = request.VendorCreditNumberSeperater,
            VendorCreditNumberDigits = request.VendorCreditNumberDigits,
            VendorCreditNumberExample = request.VendorCreditNumberExample,
        };
        await _repository.UpdateAsync(vendor);
        return request.Id;
    }
}
