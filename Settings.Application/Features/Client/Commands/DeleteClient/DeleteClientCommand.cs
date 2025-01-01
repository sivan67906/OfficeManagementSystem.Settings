using MediatR;

namespace Settings.Application.Features.Client.Commands.DeleteClient;
public class DeleteClientCommand : IRequest
{
    public Guid Id { get; set; }
}
