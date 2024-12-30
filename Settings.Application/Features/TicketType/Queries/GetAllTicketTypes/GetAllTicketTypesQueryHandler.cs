using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketTypes.Queries.GetAllTicketTypes;

internal class GetAllTicketTypesQueryHandler : IRequestHandler<GetAllTicketTypesQuery, IEnumerable<TicketTypeDTO>>
{
    private readonly IGenericRepository<TicketType> _ticketTypeRepository;

    public GetAllTicketTypesQueryHandler(
        IGenericRepository<TicketType> ticketTypeRepository)
    {
        _ticketTypeRepository = ticketTypeRepository;
    }

    public async Task<IEnumerable<TicketTypeDTO>> Handle(GetAllTicketTypesQuery request, CancellationToken cancellationToken)
    {
        var ticketTypes = await _ticketTypeRepository.GetAllAsync();
        var ticketTypeList = ticketTypes.Select(x => new TicketTypeDTO
        {
            Id = x.Id,
            TicketTypeCode = x.TicketTypeCode,
            TicketTypeName = x.TicketTypeName
        }).ToList();

        return ticketTypeList;
    }
}








































