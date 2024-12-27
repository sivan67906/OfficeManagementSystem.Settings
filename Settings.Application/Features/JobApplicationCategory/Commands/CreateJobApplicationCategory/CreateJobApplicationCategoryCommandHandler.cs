using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.JobApplicationCategories.Commands.CreateJobApplicationCategory;

internal class CreateJobApplicationCategoryCommandHandler(
    IGenericRepository<JobApplicationCategory> jobApplicationCategoryRepository) : IRequestHandler<CreateJobApplicationCategoryCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateJobApplicationCategoryCommand request, CancellationToken cancellationToken)
    {
        var jobApplicationCategory = new JobApplicationCategory
        {
            JACategoryCode = request.JACategoryCode,
            JACategoryName = request.JACategoryName,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await jobApplicationCategoryRepository.CreateAsync(jobApplicationCategory);
    }
}
























