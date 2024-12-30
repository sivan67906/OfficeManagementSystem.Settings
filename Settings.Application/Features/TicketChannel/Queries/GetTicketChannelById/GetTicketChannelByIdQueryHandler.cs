using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketChannels.Queries.GetTicketChannelById;

internal class GetTicketChannelByIdQueryHandler : IRequestHandler<GetTicketChannelByIdQuery, TicketChannelDTO>
{
    private readonly IGenericRepository<TicketChannel> _ticketChannelRepository;

    public GetTicketChannelByIdQueryHandler(
        IGenericRepository<TicketChannel> ticketChannelRepository) =>
        _ticketChannelRepository = ticketChannelRepository;

    public async Task<TicketChannelDTO> Handle(GetTicketChannelByIdQuery request, CancellationToken cancellationToken)
    {
        var ticketChannel = await _ticketChannelRepository.GetByIdAsync(request.Id);
        if (ticketChannel == null) return null;
        return new TicketChannelDTO
        {
            Id = ticketChannel.Id,
            TicketChannelCode = ticketChannel.TicketChannelCode,
            TicketChannelName = ticketChannel.TicketChannelName
        };
    }
}








































