using Settings.Application.DTOs;
using MediatR;

namespace Settings.Application.Features.Roles.Queries.GetRoleById
{
    public class GetRoleByIdQuery : IRequest<RoleDTO>
    {
        public Guid Id { get; set; }
    }
}





