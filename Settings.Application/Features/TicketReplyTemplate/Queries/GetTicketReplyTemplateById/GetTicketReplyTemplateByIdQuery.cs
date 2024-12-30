//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.TicketReplyTemplates.Queries.GetTicketReplyTemplateById
{
    public class GetTicketReplyTemplateByIdQuery : IRequest<TicketReplyTemplateDTO>
    {
        public int Id { get; set; }
    }
}








































