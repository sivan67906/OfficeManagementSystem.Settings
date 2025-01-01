using MediatR;

namespace Settings.Application.Features.Messages.Commands.DeleteMessage;
public class DeleteMessageCommand : IRequest
{
    public Guid Id { get; set; }
}
