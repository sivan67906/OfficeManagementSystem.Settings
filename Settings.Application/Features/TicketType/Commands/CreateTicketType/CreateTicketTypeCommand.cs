using MediatR;

namespace Settings.Application.Features.TicketTypes.Commands.CreateTicketType;

public class CreateTicketTypeCommand : IRequest
{
    public string? TicketTypeCode { get; set; }
    public string? TicketTypeName { get; set; }
}








































