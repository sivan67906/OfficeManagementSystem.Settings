using MediatR;

namespace Settings.Application.Features.TicketGroups.Commands.UpdateTicketGroup;

public class UpdateTicketGroupCommand : IRequest
{
    public int Id { get; set; }
    public string? TicketGroupCode { get; set; }
    public string? TicketGroupName { get; set; }
}








































