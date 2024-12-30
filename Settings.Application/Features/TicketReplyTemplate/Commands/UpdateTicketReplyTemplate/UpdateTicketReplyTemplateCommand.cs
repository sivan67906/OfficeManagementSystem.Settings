using MediatR;

namespace Settings.Application.Features.TicketReplyTemplates.Commands.UpdateTicketReplyTemplate;

public class UpdateTicketReplyTemplateCommand : IRequest
{
    public int Id { get; set; }
    public string? TicketReplyTemplateCode { get; set; }
    public string? TicketReplyTemplateName { get; set; }
}








































