using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.JobApplicationCategories.Commands.DeleteJobApplicationCategory;

internal class DeleteJobApplicationCategoryCommandHandler : IRequestHandler<DeleteJobApplicationCategoryCommand>
{
    private readonly IGenericRepository<JobApplicationCategory> _jobApplicationCategoryRepository;

    public DeleteJobApplicationCategoryCommandHandler(
        IGenericRepository<JobApplicationCategory> jobApplicationCategoryRepository) =>
        _jobApplicationCategoryRepository = jobApplicationCategoryRepository;
    public async System.Threading.Tasks.Task Handle(DeleteJobApplicationCategoryCommand request, CancellationToken cancellationToken)
    {
        await _jobApplicationCategoryRepository.DeleteAsync(request.Id);
    }
}
























