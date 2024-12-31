using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Employee.Commands.DeleteEmployee;
public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand>
{
    private readonly IGenericRepository<Domain.Entities.Employee> _employeerepo;
    public DeleteEmployeeCommandHandler(IGenericRepository<Domain.Entities.Employee> employeerepo)
    {
        _employeerepo = employeerepo;
    }

    public async System.Threading.Tasks.Task Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
    {
        if (request == null || request.Id == null)
        {
            throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
        }

        await _employeerepo.DeleteAsync(request.Id);
    }
}
