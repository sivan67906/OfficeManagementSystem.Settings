using Settings.Domain.Entities;

namespace Settings.Application.Services;

public interface ICityService
{
    Task<IEnumerable<City>> GetCitiesByParentId(Guid stateId);
}

