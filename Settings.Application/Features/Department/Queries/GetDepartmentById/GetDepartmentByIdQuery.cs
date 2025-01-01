using Settings.Application.DTOs;
using MediatR;

namespace Settings.Application.Features.Departments.Queries.GetDepartmentById
{
    public class GetDepartmentByIdQuery : IRequest<DepartmentDTO>
    {
        public Guid Id { get; set; }
    }
}


