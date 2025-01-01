using MediatR;
using Settings.Domain.Responses;

namespace Settings.Application.Features.LeadCategories.GetAllLeadCategories;

public record GetAllLeadCategoryQuery : IRequest<ServerResponse>;