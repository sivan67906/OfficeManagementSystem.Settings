using MediatR;

namespace Settings.Application.Features.ProjectCategories.Commands.CreateProjectCategory;

public class CreateProjectCategoryCommand : IRequest
{
    public string? Name { get; set; }
}












