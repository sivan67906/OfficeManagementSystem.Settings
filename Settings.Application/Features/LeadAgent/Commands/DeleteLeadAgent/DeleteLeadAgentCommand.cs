using MediatR;

namespace Settings.Application.Feauters.LeadAgent.Commands.DeleteLeadAgent
{
    public record DeleteLeadAgentCommand(Guid Id) : IRequest<string>;
}


