using MediatR;
using Settings.Domain.Responses;

namespace Settings.Application.Feauters.LeadCategory.Queries.GetLeadCategoryById;

public record GetLeadCategoryByIdQuery(Guid Id) : IRequest<ServerResponse>;