using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketTypes.Commands.CreateTicketType;

internal class CreateTicketTypeCommandHandler(
    IGenericRepository<TicketType> ticketTypeRepository) : IRequestHandler<CreateTicketTypeCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateTicketTypeCommand request, CancellationToken cancellationToken)
    {
        var ticketType = new TicketType
        {
            TicketTypeCode = request.TicketTypeCode,
            TicketTypeName = request.TicketTypeName,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await ticketTypeRepository.CreateAsync(ticketType);
    }
}








































