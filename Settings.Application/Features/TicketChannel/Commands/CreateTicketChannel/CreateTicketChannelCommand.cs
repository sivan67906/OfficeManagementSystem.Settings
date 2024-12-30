using MediatR;

namespace Settings.Application.Features.TicketChannels.Commands.CreateTicketChannel;

public class CreateTicketChannelCommand : IRequest
{
    public string? TicketChannelCode { get; set; }
    public string? TicketChannelName { get; set; }
}








































