using MediatR;

namespace Settings.Application.Features.TicketChannels.Commands.UpdateTicketChannel;

public class UpdateTicketChannelCommand : IRequest
{
    public Guid Id { get; set; }
    public string? TicketChannelCode { get; set; }
    public string? TicketChannelName { get; set; }
}








































