using Settings.Application.DTOs;
using MediatR;

namespace Settings.Application.Features.BusinessLocations.Queries.GetAllBusinessLocations;

public class GetAllBusinessLocationsQuery : IRequest<IEnumerable<BusinessLocationDTO>>
{
}

