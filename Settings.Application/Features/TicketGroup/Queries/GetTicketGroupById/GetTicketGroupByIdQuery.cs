//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.TicketGroups.Queries.GetTicketGroupById
{
    public class GetTicketGroupByIdQuery : IRequest<TicketGroupDTO>
    {
        public int Id { get; set; }
    }
}








































