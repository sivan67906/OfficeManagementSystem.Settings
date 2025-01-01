using MediatR;

namespace Settings.Application.Features.Tasks.Commands.DeleteTask;
public class DeleteTaskCommand :IRequest
{
    public Guid Id { get; set; }
}
