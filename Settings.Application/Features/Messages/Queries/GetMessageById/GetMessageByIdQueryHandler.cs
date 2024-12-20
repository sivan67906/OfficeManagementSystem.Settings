using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Messages.Queries.GetMessageById;
public class GetMessageByIdQueryHandler : IRequestHandler<GetMessageByIdQuery, MessageDTO>
{
    private readonly IGenericRepository<Message> _messageRepository;
    public GetMessageByIdQueryHandler(IGenericRepository<Message> messageRepository)
    {
        _messageRepository = messageRepository;
    }

    public async Task<MessageDTO> Handle(GetMessageByIdQuery request, CancellationToken cancellationToken)
    {
        var client = await _messageRepository.GetByIdAsync(request.Id);
        if (client == null) return null;
        return new MessageDTO
        {
            Id = client.Id,
            AllowChatClientEmployee = client.AllowChatClientEmployee,
            All = client.All,
            OnlyProjectMembercanwithclient = client.OnlyProjectMembercanwithclient,
            Allowchatclientadmin = client.Allowchatclientadmin,
            SoundNotifyAlert = client.SoundNotifyAlert
        };
    }
}
