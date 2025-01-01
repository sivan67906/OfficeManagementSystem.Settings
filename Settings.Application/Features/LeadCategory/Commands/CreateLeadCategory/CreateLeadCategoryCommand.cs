using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Responses;

namespace Settings.Application.Feauters.LeadCategory.Commands.CreateLeadCategory;

public record CreateLeadCategoryCommand(CreateLeadCategoryRequest LeadCategory) : IRequest<ServerResponse>;