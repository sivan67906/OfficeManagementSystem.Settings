using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketChannels.Commands.CreateTicketChannel;

internal class CreateTicketChannelCommandHandler(
    IGenericRepository<TicketChannel> ticketChannelRepository) : IRequestHandler<CreateTicketChannelCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateTicketChannelCommand request, CancellationToken cancellationToken)
    {
        var ticketChannel = new TicketChannel
        {
            TicketChannelCode = request.TicketChannelCode,
            TicketChannelName = request.TicketChannelName,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await ticketChannelRepository.CreateAsync(ticketChannel);
    }
}








































