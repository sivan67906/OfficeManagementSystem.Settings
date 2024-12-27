using MediatR;
using Settings.Application.DTOs;

namespace Configuration.Application.Features.Countries.Queries.GetAllCountries;

public class GetAllCountriesQuery : IRequest<IEnumerable<CountryDTO>>
{
}












