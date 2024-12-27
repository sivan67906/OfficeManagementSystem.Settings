using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.JobApplicationCategories.Queries.GetJobApplicationCategoryById;

internal class GetJobApplicationCategoryByIdQueryHandler : IRequestHandler<GetJobApplicationCategoryByIdQuery, JobApplicationCategoryDTO>
{
    private readonly IGenericRepository<JobApplicationCategory> _jobApplicationCategoryRepository;

    public GetJobApplicationCategoryByIdQueryHandler(
        IGenericRepository<JobApplicationCategory> jobApplicationCategoryRepository) =>
        _jobApplicationCategoryRepository = jobApplicationCategoryRepository;

    public async Task<JobApplicationCategoryDTO> Handle(GetJobApplicationCategoryByIdQuery request, CancellationToken cancellationToken)
    {
        var jobApplicationCategory = await _jobApplicationCategoryRepository.GetByIdAsync(request.Id);
        if (jobApplicationCategory == null) return null;
        return new JobApplicationCategoryDTO
        {
            Id = jobApplicationCategory.Id,
            JACategoryCode = jobApplicationCategory.JACategoryCode,
            JACategoryName = jobApplicationCategory.JACategoryName
        };
    }
}
























