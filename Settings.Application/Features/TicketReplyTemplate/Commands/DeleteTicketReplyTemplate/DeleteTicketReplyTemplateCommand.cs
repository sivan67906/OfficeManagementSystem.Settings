using MediatR;

namespace Settings.Application.Features.TicketReplyTemplates.Commands.DeleteTicketReplyTemplate
{
    public class DeleteTicketReplyTemplateCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}








































