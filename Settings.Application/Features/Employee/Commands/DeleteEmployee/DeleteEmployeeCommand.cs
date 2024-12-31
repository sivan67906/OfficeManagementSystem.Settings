using MediatR;

namespace Settings.Application.Features.Employee.Commands.DeleteEmployee;
public class DeleteEmployeeCommand : IRequest
{
    public int Id { get; set; }
}
