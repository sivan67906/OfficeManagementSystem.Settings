using MediatR;

namespace Settings.Application.Features.TicketGroups.Commands.DeleteTicketGroup
{
    public class DeleteTicketGroupCommand : IRequest
    {
        public int Id { get; set; }
    }
}








































