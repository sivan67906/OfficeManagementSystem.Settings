using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketChannels.Queries.GetAllTicketChannels;

internal class GetAllTicketChannelsQueryHandler : IRequestHandler<GetAllTicketChannelsQuery, IEnumerable<TicketChannelDTO>>
{
    private readonly IGenericRepository<TicketChannel> _ticketChannelRepository;

    public GetAllTicketChannelsQueryHandler(
        IGenericRepository<TicketChannel> ticketChannelRepository)
    {
        _ticketChannelRepository = ticketChannelRepository;
    }

    public async Task<IEnumerable<TicketChannelDTO>> Handle(GetAllTicketChannelsQuery request, CancellationToken cancellationToken)
    {
        var ticketChannels = await _ticketChannelRepository.GetAllAsync();
        var ticketChannelList = ticketChannels.Select(x => new TicketChannelDTO
        {
            Id = x.Id,
            TicketChannelCode = x.TicketChannelCode,
            TicketChannelName = x.TicketChannelName
        }).ToList();

        return ticketChannelList;
    }
}








































