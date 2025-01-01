using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Messages.Commands.CreateMessage;
public class CreateMessageCommandHandler : IRequestHandler<CreateMessageCommand, Guid>
{
    private readonly IGenericRepository<Message> _messagerepository;
    public CreateMessageCommandHandler(IGenericRepository<Message> messagerepository) => _messagerepository = messagerepository;

    public async Task<Guid> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
    {
        var client = new Message
        {
            AllowChatClientEmployee = request.AllowChatClientEmployee,
            All = request.All,
            OnlyProjectMembercanwithclient = request.OnlyProjectMembercanwithclient,
            Allowchatclientadmin = request.Allowchatclientadmin,
            SoundNotifyAlert = request.SoundNotifyAlert
        };

        await _messagerepository.CreateAsync(client);
        return client.Id;
    }
}
