using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketTypes.Commands.UpdateTicketType;

internal class UpdateTicketTypeCommandHandler : IRequestHandler<UpdateTicketTypeCommand>
{
    private readonly IGenericRepository<TicketType> _ticketTypeRepository;

    public UpdateTicketTypeCommandHandler(
        IGenericRepository<TicketType> ticketTypeRepository) =>
        _ticketTypeRepository = ticketTypeRepository;

    public async System.Threading.Tasks.Task Handle(UpdateTicketTypeCommand request, CancellationToken cancellationToken)
    {
        var ticketType = new TicketType
        {
            Id = request.Id,
            TicketTypeCode = request.TicketTypeCode,
            TicketTypeName = request.TicketTypeName,
            UpdatedDate = DateTime.Now
        };

        await _ticketTypeRepository.UpdateAsync(ticketType);
    }
}








































