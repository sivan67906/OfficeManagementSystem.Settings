using MediatR;
using Settings.Domain.Responses;

namespace Settings.Application.Feauters.LeadAgent.Queries.GetLeadAgentById;

public record GetLeadAgentsByIdQuery(int Id) : IRequest<ServerResponse>;


