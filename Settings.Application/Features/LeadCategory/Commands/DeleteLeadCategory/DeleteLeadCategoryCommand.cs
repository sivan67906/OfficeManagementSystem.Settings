using MediatR;
using Settings.Domain.Responses;

namespace Settings.Application.Feauters.LeadCategory.Commands.DeleteLeadCategory;
public record DeleteLeadCategoryCommand(int Id) : IRequest<ServerResponse>;