using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Tasks.Queries.GetTaskById;
public class GetTaskByIdQuery : IRequest<TaskDTO>
{
    public int Id { get; set; }
}
