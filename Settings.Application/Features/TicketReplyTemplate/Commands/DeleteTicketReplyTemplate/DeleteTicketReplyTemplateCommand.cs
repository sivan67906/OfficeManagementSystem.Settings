using MediatR;

namespace Settings.Application.Features.TicketReplyTemplates.Commands.DeleteTicketReplyTemplate
{
    public class DeleteTicketReplyTemplateCommand : IRequest
    {
        public int Id { get; set; }
    }
}








































