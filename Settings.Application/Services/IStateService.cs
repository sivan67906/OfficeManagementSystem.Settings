using Settings.Domain.Entities;

namespace Settings.Application.Services;

public interface IStateService
{
    Task<IEnumerable<State>> GetStatesByParentId(Guid countryId);
}

