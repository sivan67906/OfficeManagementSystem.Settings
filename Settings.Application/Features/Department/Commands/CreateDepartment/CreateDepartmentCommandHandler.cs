using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Departments.Commands.CreateDepartment;

internal class CreateDepartmentCommandHandler(
    IGenericRepository<Department> companyRepository) : IRequestHandler<CreateDepartmentCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
    {
        var department = new Department
        {
            Code = request.Code,
            Name = request.Name,
            CompanyId = request.CompanyId,
            Email = request.Email,
            Description = request.Description,
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,
            IsActive = request.IsActive
        };

        await companyRepository.CreateAsync(department);
    }
}


