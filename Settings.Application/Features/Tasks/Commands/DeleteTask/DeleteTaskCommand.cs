using MediatR;

namespace Settings.Application.Features.Tasks.Commands.DeleteTask;
public class DeleteTaskCommand :IRequest
{
    public int Id { get; set; }
}
