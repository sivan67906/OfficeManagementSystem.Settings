using MediatR;

namespace Settings.Application.Features.TicketTypes.Commands.DeleteTicketType
{
    public class DeleteTicketTypeCommand : IRequest
    {
        public int Id { get; set; }
    }
}








































