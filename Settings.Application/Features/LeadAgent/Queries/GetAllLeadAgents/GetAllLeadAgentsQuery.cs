using MediatR;
using Settings.Domain.Responses;

namespace Settings.Application.Feauters.LeadAgent.Queries.GetAllLeadAgents;

public record GetAllLeadAgentsQuery : IRequest<ServerResponse>;


