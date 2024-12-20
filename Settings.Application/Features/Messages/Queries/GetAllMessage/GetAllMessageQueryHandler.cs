using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Messages.Queries.GetAllMessage;
public class GetAllMessageQueryHandler : IRequestHandler<GetAllMessageQuery, IEnumerable<MessageDTO>>
{
    private readonly IGenericRepository<Message> _messagerepo;
    public GetAllMessageQueryHandler(IGenericRepository<Message> messagerepo)
    {
        _messagerepo = messagerepo;
    }

    public async Task<IEnumerable<MessageDTO>> Handle(GetAllMessageQuery request, CancellationToken cancellationToken)
    {
        var clients = await _messagerepo.GetAllAsync();

        var clientlist = clients.Select(x => new MessageDTO
        {
            Id = x.Id,
            AllowChatClientEmployee = x.AllowChatClientEmployee,
            All = x.All,
            OnlyProjectMembercanwithclient = x.OnlyProjectMembercanwithclient,
            Allowchatclientadmin = x.Allowchatclientadmin,
            SoundNotifyAlert = x.SoundNotifyAlert
        }).ToList();

        return clientlist;
    }
}
