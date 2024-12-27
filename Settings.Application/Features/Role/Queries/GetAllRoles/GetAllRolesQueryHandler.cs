using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;
using MediatR;

namespace Settings.Application.Features.Roles.Queries.GetAllRoles;

internal class GetAllRolesQueryHandler : IRequestHandler<GetAllRolesQuery, IEnumerable<RoleDTO>>
{
    private readonly IGenericRepository<Role> _roleRepository;

    public GetAllRolesQueryHandler(
        IGenericRepository<Role> roleRepository) =>
        _roleRepository = roleRepository;

    public async Task<IEnumerable<RoleDTO>> Handle(GetAllRolesQuery request, CancellationToken cancellationToken)
    {
        var companies = await _roleRepository.GetAllAsync();

        var roleList = companies.Select(x => new RoleDTO
        {
            Id = x.Id,
            Code = x.Code,
            Name = x.Name,
            Description = x.Description,
            CompanyId = x.CompanyId,
            DepartmentId = x.DepartmentId,
            DesignationId = x.DesignationId,
            CompanyName = x.Company.Name,
            DepartmentName = x.Department.Name,
            DesignationName = x.Designation.Name,
            CreatedDate = x.CreatedDate,
            UpdatedDate = x.UpdatedDate,
            IsActive = x.IsActive
        }).ToList();

        return roleList;
    }
}





