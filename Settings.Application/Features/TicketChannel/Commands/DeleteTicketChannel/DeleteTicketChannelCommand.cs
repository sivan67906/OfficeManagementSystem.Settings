using MediatR;

namespace Settings.Application.Features.TicketChannels.Commands.DeleteTicketChannel
{
    public class DeleteTicketChannelCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}








































