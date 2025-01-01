using MediatR;

namespace Settings.Application.Features.TicketTypes.Commands.DeleteTicketType
{
    public class DeleteTicketTypeCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}








































