using Settings.Domain.Entities;
using MediatR;

namespace Settings.Application.Features.BusinessTypes.Queries.GetAllBusinessTypes;

public class GetAllBusinessTypesQuery : IRequest<IEnumerable<BusinessTypeDTO>>
{
}






