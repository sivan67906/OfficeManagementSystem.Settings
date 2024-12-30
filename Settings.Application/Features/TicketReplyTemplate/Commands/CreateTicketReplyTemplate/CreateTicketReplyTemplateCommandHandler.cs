using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketReplyTemplates.Commands.CreateTicketReplyTemplate;

internal class CreateTicketReplyTemplateCommandHandler(
    IGenericRepository<TicketReplyTemplate> ticketReplyTemplateRepository) : IRequestHandler<CreateTicketReplyTemplateCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateTicketReplyTemplateCommand request, CancellationToken cancellationToken)
    {
        var ticketReplyTemplate = new TicketReplyTemplate
        {
            TicketReplyTemplateCode = request.TicketReplyTemplateCode,
            TicketReplyTemplateName = request.TicketReplyTemplateName,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await ticketReplyTemplateRepository.CreateAsync(ticketReplyTemplate);
    }
}








































