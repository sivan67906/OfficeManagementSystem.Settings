using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Contracts.Queries.GetAllContract;
public class GetAllContractQueryHandler : IRequestHandler<GetAllContractQuery, IEnumerable<ContractDTO>>
{
    private readonly IGenericRepository<Contract> _contractRepository;
    public GetAllContractQueryHandler(IGenericRepository<Contract> repository) => _contractRepository = repository;

    public async Task<IEnumerable<ContractDTO>> Handle(GetAllContractQuery request, CancellationToken cancellationToken)
    {
        var currencys = await _contractRepository.GetAllAsync();

        var currencylist = currencys.Select(x => new ContractDTO
        {
            Id = x.Id,
            ContractPrefix = x.ContractPrefix,
            ContractNumberSeprator = x.ContractNumberSeprator,
            ContractNumberDigits = x.ContractNumberDigits,
            ContractNumberExample = x.ContractNumberExample,
        }).ToList();

        return currencylist;
    }
}