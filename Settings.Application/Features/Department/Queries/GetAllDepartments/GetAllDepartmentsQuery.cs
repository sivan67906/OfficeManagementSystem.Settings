using Settings.Application.DTOs;
using MediatR;

namespace Settings.Application.Features.Departments.Queries.GetAllDepartments;

public class GetAllDepartmentsQuery : IRequest<IEnumerable<DepartmentDTO>>
{

}


