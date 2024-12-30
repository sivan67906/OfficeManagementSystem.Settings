using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketTypes.Commands.DeleteTicketType;

internal class DeleteTicketTypeCommandHandler : IRequestHandler<DeleteTicketTypeCommand>
{
    private readonly IGenericRepository<TicketType> _timeLogRepository;

    public DeleteTicketTypeCommandHandler(
        IGenericRepository<TicketType> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;
    public async System.Threading.Tasks.Task Handle(DeleteTicketTypeCommand request, CancellationToken cancellationToken)
    {
        await _timeLogRepository.DeleteAsync(request.Id);
    }
}








































