using Settings.Application.DTOs;
using MediatR;

namespace Settings.Application.Features.Cities.Queries.GetCitiesByParentId;
public class GetCitiesByParentIdQuery : IRequest<IEnumerable<CityDTO>>
{
    public Guid StateId { get; set; }
}

