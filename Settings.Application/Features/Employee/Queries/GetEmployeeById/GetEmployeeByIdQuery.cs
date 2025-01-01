using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Employee.Queries.GetEmployeeById;
public class GetEmployeeByIdQuery : IRequest<EmployeeDTO>
{
    public Guid Id { get; set; }
}
