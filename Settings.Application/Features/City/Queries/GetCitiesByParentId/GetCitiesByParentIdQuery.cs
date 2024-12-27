using MediatR;
using Settings.Application.DTOs;

namespace Configuration.Application.Features.Cities.Queries.GetCitiesByParentId;
public class GetCitiesByParentIdQuery : IRequest<IEnumerable<CityDTO>>
{
    public int StateId { get; set; }
}
