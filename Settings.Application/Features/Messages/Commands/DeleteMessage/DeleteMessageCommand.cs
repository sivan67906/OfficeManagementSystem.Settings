using MediatR;

namespace Settings.Application.Features.Messages.Commands.DeleteMessage;
public class DeleteMessageCommand : IRequest
{
    public int Id { get; set; }
}
