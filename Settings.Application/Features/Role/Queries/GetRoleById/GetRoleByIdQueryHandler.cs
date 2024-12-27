using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;
using MediatR;

namespace Settings.Application.Features.Roles.Queries.GetRoleById;

internal class GetRoleByIdQueryHandler : IRequestHandler<GetRoleByIdQuery, RoleDTO>
{
    private readonly IGenericRepository<Role> _roleRepository;

    public GetRoleByIdQueryHandler(
        IGenericRepository<Role> roleRepository) =>
        _roleRepository = roleRepository;

    public async Task<RoleDTO> Handle(GetRoleByIdQuery request, CancellationToken cancellationToken)
    {
        var role = await _roleRepository.GetByIdAsync(request.Id);
        if (role == null) return null;
        return new RoleDTO
        {
            Id = role.Id,
            Code = role.Code,
            Name = role.Name,
            Description = role.Description,
            CompanyId = role.CompanyId,
            DepartmentId = role.DepartmentId,
            DesignationId = role.DesignationId,
            CreatedDate = role.CreatedDate,
            UpdatedDate = role.UpdatedDate,
            IsActive = role.IsActive
        };
    }
}





