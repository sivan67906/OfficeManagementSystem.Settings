using Settings.Application.Services;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Infrastructure.Services;

public class StateService(IGenericRepository<State> stateRepository)
    : IStateService
{
    public async Task<IEnumerable<State>> GetStatesByParentId(Guid countryId)
    {
        var states = await stateRepository.GetAllAsync();
        var finalStateList = states.Where(x => x.CountryId == countryId && x.IsActive == true);
        return finalStateList;
    }
}

