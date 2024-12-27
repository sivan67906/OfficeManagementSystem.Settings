using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Departments.Commands.DeleteDepartment;

internal class DeleteDepartmentCommandHandler : IRequestHandler<DeleteDepartmentCommand>
{
    private readonly IGenericRepository<Department> _departmentRepository;

    public DeleteDepartmentCommandHandler(
        IGenericRepository<Department> departmentRepository) =>
        _departmentRepository = departmentRepository;
    public async System.Threading.Tasks.Task Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
    {
        await _departmentRepository.DeleteAsync(request.Id);
    }
}


