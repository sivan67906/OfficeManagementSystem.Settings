using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Responses;

namespace Settings.Application.Feauters.LeadCategory.Commands.UpdateLeadCategory;

public record UpdateLeadCategoryCommand(UpdateLeadCategoryRequest LeadCategory) : IRequest<ServerResponse>;