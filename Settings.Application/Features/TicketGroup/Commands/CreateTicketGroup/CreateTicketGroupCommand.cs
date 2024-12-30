using MediatR;

namespace Settings.Application.Features.TicketGroups.Commands.CreateTicketGroup;

public class CreateTicketGroupCommand : IRequest
{
    public string? TicketGroupCode { get; set; }
    public string? TicketGroupName { get; set; }
}








































