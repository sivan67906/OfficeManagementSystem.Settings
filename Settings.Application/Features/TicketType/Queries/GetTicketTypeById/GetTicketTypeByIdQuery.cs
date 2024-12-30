//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.TicketTypes.Queries.GetTicketTypeById
{
    public class GetTicketTypeByIdQuery : IRequest<TicketTypeDTO>
    {
        public int Id { get; set; }
    }
}








































