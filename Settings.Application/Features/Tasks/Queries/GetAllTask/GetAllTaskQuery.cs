using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Tasks.Queries.GetAllTask;
public class GetAllTaskQuery : IRequest<IEnumerable<TaskDTO>>
{

}
