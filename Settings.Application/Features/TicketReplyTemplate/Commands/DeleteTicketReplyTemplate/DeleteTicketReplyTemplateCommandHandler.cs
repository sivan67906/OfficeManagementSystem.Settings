using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketReplyTemplates.Commands.DeleteTicketReplyTemplate;

internal class DeleteTicketReplyTemplateCommandHandler : IRequestHandler<DeleteTicketReplyTemplateCommand>
{
    private readonly IGenericRepository<TicketReplyTemplate> _timeLogRepository;

    public DeleteTicketReplyTemplateCommandHandler(
        IGenericRepository<TicketReplyTemplate> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;
    public async System.Threading.Tasks.Task Handle(DeleteTicketReplyTemplateCommand request, CancellationToken cancellationToken)
    {
        await _timeLogRepository.DeleteAsync(request.Id);
    }
}








































