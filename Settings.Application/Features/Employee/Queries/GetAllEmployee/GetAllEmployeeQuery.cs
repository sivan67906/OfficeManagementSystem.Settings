using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Employee.Queries.GetAllEmployee;
public class GetAllEmployeeQuery : IRequest<IEnumerable<EmployeeDTO>>
{
}
