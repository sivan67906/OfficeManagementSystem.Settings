using Settings.Application.DTOs;
using MediatR;

namespace Settings.Application.Features.Designations.Queries.GetAllDesignations;

public class GetAllDesignationsQuery : IRequest<IEnumerable<DesignationDTO>>
{
}






