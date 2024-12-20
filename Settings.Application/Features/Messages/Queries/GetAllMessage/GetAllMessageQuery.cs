using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Messages.Queries.GetAllMessage;
public class GetAllMessageQuery : IRequest<IEnumerable<MessageDTO>>
{
}
