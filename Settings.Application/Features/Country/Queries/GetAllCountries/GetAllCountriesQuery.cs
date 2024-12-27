using Settings.Domain.Entities;
using MediatR;

namespace Settings.Application.Features.Countries.Queries.GetAllCountries;

public class GetAllCountriesQuery : IRequest<IEnumerable<CountryDTO>>
{
}













