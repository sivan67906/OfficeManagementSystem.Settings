using Settings.Application.DTOs;
using MediatR;

namespace Settings.Application.Features.Roles.Queries.GetRoleById
{
    public class GetRoleByIdQuery : IRequest<RoleDTO>
    {
        public int Id { get; set; }
    }
}





