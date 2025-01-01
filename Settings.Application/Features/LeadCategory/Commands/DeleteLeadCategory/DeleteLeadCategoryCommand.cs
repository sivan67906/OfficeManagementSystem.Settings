using MediatR;
using Settings.Domain.Responses;

namespace Settings.Application.Feauters.LeadCategory.Commands.DeleteLeadCategory;
public record DeleteLeadCategoryCommand(Guid Id) : IRequest<ServerResponse>;