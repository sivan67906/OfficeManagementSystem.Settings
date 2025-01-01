using MediatR;
using Settings.Application.DTOs.Lead;
using Settings.Domain.Responses;

namespace Settings.Application.Features.LeadCategories.CreateLeadCategory;

public record CreateLeadCategoryCommand(CreateLeadCategoryRequest LeadCategory) : IRequest<ServerResponse>;