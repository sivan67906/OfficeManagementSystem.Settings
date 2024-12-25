using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Taxes.Commands.CreateTax;
public class CreateTaxCommandHandler : IRequestHandler<CreateTaxCommand, int>
{
    private readonly IGenericRepository<Tax> _taxrepo;
    public CreateTaxCommandHandler(IGenericRepository<Tax> taxrepo) => _taxrepo = taxrepo;

    public async Task<int> Handle(CreateTaxCommand request, CancellationToken cancellationToken)
    {
        var tax = new Tax
        {
            Name = request.Name,
            Rate = request.Rate
        };
        await _taxrepo.CreateAsync(tax);
        return tax.Id;
    }
}
