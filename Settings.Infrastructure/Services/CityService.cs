using Settings.Application.Services;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Infrastructure.Services;

public class CityService(IGenericRepository<City> cityRepository)
    : ICityService
{
    public async Task<IEnumerable<City>> GetCitiesByParentId(int stateId)
    {
        var cities = await cityRepository.GetAllAsync();
        return cities.Where(x => x.StateId == stateId && x.IsActive == true);
    }
}

