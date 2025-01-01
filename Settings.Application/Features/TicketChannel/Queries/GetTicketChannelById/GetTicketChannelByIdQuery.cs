//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.TicketChannels.Queries.GetTicketChannelById
{
    public class GetTicketChannelByIdQuery : IRequest<TicketChannelDTO>
    {
        public Guid Id { get; set; }
    }
}








































