using MediatR;

namespace Settings.Application.Features.ProjectCategories.Commands.UpdateProjectCategory;

public class UpdateProjectCategoryCommand : IRequest
{
    public int Id { get; set; }
    public string? Name { get; set; }
}












