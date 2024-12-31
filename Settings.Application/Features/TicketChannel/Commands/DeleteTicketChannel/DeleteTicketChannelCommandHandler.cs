using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketChannels.Commands.DeleteTicketChannel;

internal class DeleteTicketChannelCommandHandler : IRequestHandler<DeleteTicketChannelCommand>
{
    private readonly IGenericRepository<TicketChannel> _timeLogRepository;

    public DeleteTicketChannelCommandHandler(
        IGenericRepository<TicketChannel> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;
    public async System.Threading.Tasks.Task Handle(DeleteTicketChannelCommand request, CancellationToken cancellationToken)
    {
        await _timeLogRepository.DeleteAsync(request.Id);
    }
}








































