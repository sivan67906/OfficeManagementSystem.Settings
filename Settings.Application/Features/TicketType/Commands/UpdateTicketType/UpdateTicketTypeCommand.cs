using MediatR;

namespace Settings.Application.Features.TicketTypes.Commands.UpdateTicketType;

public class UpdateTicketTypeCommand : IRequest
{
    public Guid Id { get; set; }
    public string? TicketTypeCode { get; set; }
    public string? TicketTypeName { get; set; }
}








































