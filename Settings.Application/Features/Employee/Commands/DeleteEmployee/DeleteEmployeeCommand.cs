using MediatR;

namespace Settings.Application.Features.Employee.Commands.DeleteEmployee;
public class DeleteEmployeeCommand : IRequest
{
    public Guid Id { get; set; }
}
