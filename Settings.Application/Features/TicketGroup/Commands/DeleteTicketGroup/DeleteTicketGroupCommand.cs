using MediatR;

namespace Settings.Application.Features.TicketGroups.Commands.DeleteTicketGroup
{
    public class DeleteTicketGroupCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}








































