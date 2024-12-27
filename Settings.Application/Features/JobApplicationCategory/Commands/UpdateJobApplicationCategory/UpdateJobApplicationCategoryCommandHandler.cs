using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.JobApplicationCategories.Commands.UpdateJobApplicationCategory;

internal class UpdateJobApplicationCategoryCommandHandler : IRequestHandler<UpdateJobApplicationCategoryCommand>
{
    private readonly IGenericRepository<JobApplicationCategory> _jobApplicationCategoryRepository;

    public UpdateJobApplicationCategoryCommandHandler(
        IGenericRepository<JobApplicationCategory> jobApplicationCategoryRepository) =>
        _jobApplicationCategoryRepository = jobApplicationCategoryRepository;

    public async System.Threading.Tasks.Task Handle(UpdateJobApplicationCategoryCommand request, CancellationToken cancellationToken)
    {
        var jobApplicationCategory = new JobApplicationCategory
        {
            Id = request.Id,
            JACategoryCode = request.JACategoryCode,
            JACategoryName = request.JACategoryName,
            UpdatedDate = DateTime.Now
        };

        await _jobApplicationCategoryRepository.UpdateAsync(jobApplicationCategory);
    }
}
























