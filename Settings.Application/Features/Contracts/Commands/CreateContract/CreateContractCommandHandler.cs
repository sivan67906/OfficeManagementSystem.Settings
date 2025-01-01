using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Contracts.Commands.CreateContract;
public class CreateContractCommandHandler : IRequestHandler<CreateContractCommand, Guid>
{
    private readonly IGenericRepository<Contract> _contractRepo;
    public CreateContractCommandHandler(IGenericRepository<Contract> repository) => _contractRepo = repository;

    public async Task<Guid> Handle(CreateContractCommand request, CancellationToken cancellationToken)
    {
        var Contract = new Contract
        {
            ContractPrefix = request.ContractPrefix,
            ContractNumberSeprator = request.ContractNumberSeprator,
            ContractNumberDigits = request.ContractNumberDigits,
            ContractNumberExample = request.ContractNumberExample,
        };
        await _contractRepo.CreateAsync(Contract);
        return Contract.Id;
    }
}