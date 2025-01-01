using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Feauters.LeadAgent.Commands.CreateLeadAgent
{
    public record CreateLeadAgentCommand(CreateLeadAgentRequest LeadAgent) : IRequest<string>;
}


