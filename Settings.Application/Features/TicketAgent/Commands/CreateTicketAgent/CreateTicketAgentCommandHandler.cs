using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TicketAgents.Commands.CreateTicketAgent;

internal class CreateTicketAgentCommandHandler(
    IGenericRepository<TicketAgent> ticketAgentRepository) : IRequestHandler<CreateTicketAgentCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateTicketAgentCommand request, CancellationToken cancellationToken)
    {
        var ticketAgent = new TicketAgent
        {
            TicketAgentCode = request.TicketAgentCode,
            TicketAgentName = request.TicketAgentName,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await ticketAgentRepository.CreateAsync(ticketAgent);
    }
}














































