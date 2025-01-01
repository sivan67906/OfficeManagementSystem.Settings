using MediatR;
using Settings.Application.DTOs.LeadCategory;
using Settings.Domain.Responses;

namespace Settings.Application.Features.LeadCategories.UpdateLeadCategory;

public record UpdateLeadCategoryCommand(UpdateLeadCategoryRequest LeadCategory) : IRequest<ServerResponse>;