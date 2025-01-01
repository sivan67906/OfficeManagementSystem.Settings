using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Feauters.LeadAgent.Commands.UpdateLeadAgent
{
    public record UpdateLeadAgentCommand(UpdateLeadAgentRequest LeadAgent) : IRequest<string>;
}


