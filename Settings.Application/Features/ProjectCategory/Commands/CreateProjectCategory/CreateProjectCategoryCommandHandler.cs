using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.ProjectCategories.Commands.CreateProjectCategory;

internal class CreateProjectCategoryCommandHandler(
    IGenericRepository<ProjectCategory> projectCategoryRepository) : IRequestHandler<CreateProjectCategoryCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateProjectCategoryCommand request, CancellationToken cancellationToken)
    {
        var projectCategory = new ProjectCategory
        {
            Name = request.Name,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await projectCategoryRepository.CreateAsync(projectCategory);
    }
}












