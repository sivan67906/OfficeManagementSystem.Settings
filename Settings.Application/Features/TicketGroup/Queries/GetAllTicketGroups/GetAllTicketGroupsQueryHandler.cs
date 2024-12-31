using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketGroups.Queries.GetAllTicketGroups;

internal class GetAllTicketGroupsQueryHandler : IRequestHandler<GetAllTicketGroupsQuery, IEnumerable<TicketGroupDTO>>
{
    private readonly IGenericRepository<TicketGroup> _ticketGroupRepository;

    public GetAllTicketGroupsQueryHandler(
        IGenericRepository<TicketGroup> ticketGroupRepository)
    {
        _ticketGroupRepository = ticketGroupRepository;
    }

    public async Task<IEnumerable<TicketGroupDTO>> Handle(GetAllTicketGroupsQuery request, CancellationToken cancellationToken)
    {
        var ticketGroups = await _ticketGroupRepository.GetAllAsync();
        var ticketGroupList = ticketGroups.Select(x => new TicketGroupDTO
        {
            Id = x.Id,
            TicketGroupCode = x.TicketGroupCode,
            TicketGroupName = x.TicketGroupName
        }).ToList();

        return ticketGroupList;
    }
}








































