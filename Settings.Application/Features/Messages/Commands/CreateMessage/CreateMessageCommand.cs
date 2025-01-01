﻿using MediatR;

namespace Settings.Application.Features.Messages.Commands.CreateMessage;
public class CreateMessageCommand : IRequest<Guid>
{
    public bool AllowChatClientEmployee { get; set; }
    public bool All { get; set; }
    public bool OnlyProjectMembercanwithclient { get; set; }
    public bool Allowchatclientadmin { get; set; }
    public bool SoundNotifyAlert { get; set; }
}
