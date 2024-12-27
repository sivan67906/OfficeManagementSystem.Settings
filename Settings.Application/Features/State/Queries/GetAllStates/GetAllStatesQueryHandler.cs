using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Configuration.Application.Features.States.Queries.GetAllStates;

internal class GetAllStatesQueryHandler : IRequestHandler<GetAllStatesQuery, IEnumerable<StateDTO>>
{
    private readonly IGenericRepository<State> _stateRepository;

    public GetAllStatesQueryHandler(
        IGenericRepository<State> stateRepository) =>
        _stateRepository = stateRepository;

    public async Task<IEnumerable<StateDTO>> Handle(GetAllStatesQuery request, CancellationToken cancellationToken)
    {
        var companies = await _stateRepository.GetAllAsync();

        var stateList = companies.Select(x => new StateDTO
        {
            Id = x.Id,
            Code = x.Code,
            Name = x.Name,
            CountryId = x.CountryId,
            CreatedDate = x.CreatedDate,
            UpdatedDate = x.UpdatedDate,
            IsActive = x.IsActive
        }).ToList();

        return stateList;
    }
}












