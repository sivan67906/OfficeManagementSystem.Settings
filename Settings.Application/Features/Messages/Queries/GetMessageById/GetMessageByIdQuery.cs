﻿using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Messages.Queries.GetMessageById;
public class GetMessageByIdQuery : IRequest<MessageDTO>
{
    public Guid Id { get; set; }
}
