using MediatR;

namespace Settings.Application.Features.TicketChannels.Commands.DeleteTicketChannel
{
    public class DeleteTicketChannelCommand : IRequest
    {
        public int Id { get; set; }
    }
}








































