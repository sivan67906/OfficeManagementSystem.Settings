using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketGroups.Commands.UpdateTicketGroup;

internal class UpdateTicketGroupCommandHandler : IRequestHandler<UpdateTicketGroupCommand>
{
    private readonly IGenericRepository<TicketGroup> _ticketGroupRepository;

    public UpdateTicketGroupCommandHandler(
        IGenericRepository<TicketGroup> ticketGroupRepository) =>
        _ticketGroupRepository = ticketGroupRepository;

    public async System.Threading.Tasks.Task Handle(UpdateTicketGroupCommand request, CancellationToken cancellationToken)
    {
        var ticketGroup = new TicketGroup
        {
            Id = request.Id,
            TicketGroupCode = request.TicketGroupCode,
            TicketGroupName = request.TicketGroupName,
            UpdatedDate = DateTime.Now
        };

        await _ticketGroupRepository.UpdateAsync(ticketGroup);
    }
}








































