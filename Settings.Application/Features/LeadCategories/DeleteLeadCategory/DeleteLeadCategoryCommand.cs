using MediatR;
using Settings.Domain.Responses;

namespace Settings.Application.Features.LeadCategories.DeleteLeadCategory;
public record DeleteLeadCategoryCommand(Guid Id) : IRequest<ServerResponse>;