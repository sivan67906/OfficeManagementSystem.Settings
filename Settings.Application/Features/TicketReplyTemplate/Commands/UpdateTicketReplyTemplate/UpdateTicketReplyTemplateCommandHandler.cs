using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketReplyTemplates.Commands.UpdateTicketReplyTemplate;

internal class UpdateTicketReplyTemplateCommandHandler : IRequestHandler<UpdateTicketReplyTemplateCommand>
{
    private readonly IGenericRepository<TicketReplyTemplate> _ticketReplyTemplateRepository;

    public UpdateTicketReplyTemplateCommandHandler(
        IGenericRepository<TicketReplyTemplate> ticketReplyTemplateRepository) =>
        _ticketReplyTemplateRepository = ticketReplyTemplateRepository;

    public async System.Threading.Tasks.Task Handle(UpdateTicketReplyTemplateCommand request, CancellationToken cancellationToken)
    {
        var ticketReplyTemplate = new TicketReplyTemplate
        {
            Id = request.Id,
            TicketReplyTemplateCode = request.TicketReplyTemplateCode,
            TicketReplyTemplateName = request.TicketReplyTemplateName,
            UpdatedDate = DateTime.Now
        };

        await _ticketReplyTemplateRepository.UpdateAsync(ticketReplyTemplate);
    }
}








































