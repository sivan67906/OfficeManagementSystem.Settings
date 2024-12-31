using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketGroups.Commands.CreateTicketGroup;

internal class CreateTicketGroupCommandHandler(
    IGenericRepository<TicketGroup> ticketGroupRepository) : IRequestHandler<CreateTicketGroupCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateTicketGroupCommand request, CancellationToken cancellationToken)
    {
        var ticketGroup = new TicketGroup
        {
            TicketGroupCode = request.TicketGroupCode,
            TicketGroupName = request.TicketGroupName,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await ticketGroupRepository.CreateAsync(ticketGroup);
    }
}








































