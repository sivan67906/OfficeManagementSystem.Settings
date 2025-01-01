using MediatR;
using Settings.Domain.Responses;

namespace Settings.Application.Feauters.LeadCategory.Queries.GetAllLeadCategories;

public record GetAllLeadCategoryQuery : IRequest<ServerResponse>;