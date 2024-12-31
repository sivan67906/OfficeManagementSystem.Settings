using MediatR;

namespace Settings.Application.Features.TicketReplyTemplates.Commands.CreateTicketReplyTemplate;

public class CreateTicketReplyTemplateCommand : IRequest
{
    public string? TicketReplyTemplateCode { get; set; }
    public string? TicketReplyTemplateName { get; set; }
}








































