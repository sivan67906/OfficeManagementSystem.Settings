using MediatR;
using Settings.Domain.Responses;

namespace Settings.Application.Features.LeadCategories.GetLeadCategoryById;

public record GetLeadCategoryByIdQuery(Guid Id) : IRequest<ServerResponse>;