using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketChannels.Commands.UpdateTicketChannel;

internal class UpdateTicketChannelCommandHandler : IRequestHandler<UpdateTicketChannelCommand>
{
    private readonly IGenericRepository<TicketChannel> _ticketChannelRepository;

    public UpdateTicketChannelCommandHandler(
        IGenericRepository<TicketChannel> ticketChannelRepository) =>
        _ticketChannelRepository = ticketChannelRepository;

    public async System.Threading.Tasks.Task Handle(UpdateTicketChannelCommand request, CancellationToken cancellationToken)
    {
        var ticketChannel = new TicketChannel
        {
            Id = request.Id,
            TicketChannelCode = request.TicketChannelCode,
            TicketChannelName = request.TicketChannelName,
            UpdatedDate = DateTime.Now
        };

        await _ticketChannelRepository.UpdateAsync(ticketChannel);
    }
}








































