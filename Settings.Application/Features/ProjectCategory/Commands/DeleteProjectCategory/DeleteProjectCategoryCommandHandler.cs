using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.ProjectCategories.Commands.DeleteProjectCategory;

internal class DeleteProjectCategoryCommandHandler : IRequestHandler<DeleteProjectCategoryCommand>
{
    private readonly IGenericRepository<ProjectCategory> _projectCategoryRepository;

    public DeleteProjectCategoryCommandHandler(
        IGenericRepository<ProjectCategory> projectCategoryRepository) =>
        _projectCategoryRepository = projectCategoryRepository;
    public async System.Threading.Tasks.Task Handle(DeleteProjectCategoryCommand request, CancellationToken cancellationToken)
    {
        await _projectCategoryRepository.DeleteAsync(request.Id);
    }
}












