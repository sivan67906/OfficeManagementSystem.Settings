using Settings.Application.DTOs;
using MediatR;

namespace Settings.Application.Features.Roles.Queries.GetAllRoles;

public class GetAllRolesQuery : IRequest<IEnumerable<RoleDTO>>
{
}





