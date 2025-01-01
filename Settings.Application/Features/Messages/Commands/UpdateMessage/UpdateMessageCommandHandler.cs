﻿using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Messages.Commands.UpdateMessage;
public class UpdateMessageCommandHandler : IRequestHandler<UpdateMessageCommand, Guid>
{
    private readonly IGenericRepository<Message> _messagerepo;
    public UpdateMessageCommandHandler(IGenericRepository<Message> messagerepo) => _messagerepo = messagerepo;

    public async Task<Guid> Handle(UpdateMessageCommand request, CancellationToken cancellationToken)
    {
        var product = new Message
        {
            Id = request.Id,
            AllowChatClientEmployee = request.AllowChatClientEmployee,
            All = request.All,
            OnlyProjectMembercanwithclient = request.OnlyProjectMembercanwithclient,
            Allowchatclientadmin = request.Allowchatclientadmin,
            SoundNotifyAlert = request.SoundNotifyAlert
        };
        await _messagerepo.UpdateAsync(product);
        return request.Id;
    }
}
