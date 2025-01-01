using MediatR;

namespace Settings.Application.Features.ProjectCategories.Commands.UpdateProjectCategory;

public class UpdateProjectCategoryCommand : IRequest
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
}












