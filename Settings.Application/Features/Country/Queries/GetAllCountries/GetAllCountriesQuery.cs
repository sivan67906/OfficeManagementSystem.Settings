using MediatR;
using Settings.Domain.Entities;

namespace Settings.Application.Features.Countries.Queries.GetAllCountries;

public class GetAllCountriesQuery : IRequest<IEnumerable<CountryDTO>>
{
}













