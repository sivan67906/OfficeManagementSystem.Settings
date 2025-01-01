using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Contracts.Commands.UpdateContract;
public class UpdateContractCommandHandler : IRequestHandler<UpdateContractCommand, Guid>
{
    private IGenericRepository<Contract> _contractRepository;
    public UpdateContractCommandHandler(IGenericRepository<Contract> repository) => _contractRepository = repository;

    public async Task<Guid> Handle(UpdateContractCommand request, CancellationToken cancellationToken)
    {
        var currency = new Contract
        {
            Id = request.Id,
            ContractPrefix = request.ContractPrefix,
            ContractNumberSeprator = request.ContractNumberSeprator,
            ContractNumberDigits = request.ContractNumberDigits,
            ContractNumberExample = request.ContractNumberExample,
        };
        await _contractRepository.UpdateAsync(currency);
        return request.Id;
    }
}
