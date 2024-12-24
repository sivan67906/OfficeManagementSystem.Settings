using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.ProjectCategories.Queries.GetProjectCategoryById;

internal class GetProjectCategoryByIdQueryHandler : IRequestHandler<GetProjectCategoryByIdQuery, ProjectCategoryDTO>
{
    private readonly IGenericRepository<ProjectCategory> _projectCategoryRepository;

    public GetProjectCategoryByIdQueryHandler(
        IGenericRepository<ProjectCategory> projectCategoryRepository) =>
        _projectCategoryRepository = projectCategoryRepository;

    public async Task<ProjectCategoryDTO> Handle(GetProjectCategoryByIdQuery request, CancellationToken cancellationToken)
    {
        var projectCategory = await _projectCategoryRepository.GetByIdAsync(request.Id);
        if (projectCategory == null) return null;
        return new ProjectCategoryDTO
        {
            Id = projectCategory.Id,
            Name = projectCategory.Name
        };
    }
}












