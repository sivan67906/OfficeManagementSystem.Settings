using Settings.Application.DTOs;
using MediatR;

namespace Settings.Application.Features.ProjectStatuses.Queries.GetProjectStatusById
{
    public class GetProjectStatusByIdQuery : IRequest<ProjectStatusDTO>
    {
        public Guid Id { get; set; }
    }
}
















