using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketTypes.Queries.GetTicketTypeById;

internal class GetTicketTypeByIdQueryHandler : IRequestHandler<GetTicketTypeByIdQuery, TicketTypeDTO>
{
    private readonly IGenericRepository<TicketType> _ticketTypeRepository;

    public GetTicketTypeByIdQueryHandler(
        IGenericRepository<TicketType> ticketTypeRepository) =>
        _ticketTypeRepository = ticketTypeRepository;

    public async Task<TicketTypeDTO> Handle(GetTicketTypeByIdQuery request, CancellationToken cancellationToken)
    {
        var ticketType = await _ticketTypeRepository.GetByIdAsync(request.Id);
        if (ticketType == null) return null;
        return new TicketTypeDTO
        {
            Id = ticketType.Id,
            TicketTypeCode = ticketType.TicketTypeCode,
            TicketTypeName = ticketType.TicketTypeName
        };
    }
}








































