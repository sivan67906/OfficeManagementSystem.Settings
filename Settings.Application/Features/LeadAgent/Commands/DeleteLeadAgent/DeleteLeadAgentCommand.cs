using MediatR;

namespace Settings.Application.Feauters.LeadAgent.Commands.DeleteLeadAgent
{
    public record DeleteLeadAgentCommand(int Id) : IRequest<string>;
}


