using MediatR;

namespace Settings.Application.Features.JobApplicationCategories.Commands.DeleteJobApplicationCategory
{
    public class DeleteJobApplicationCategoryCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
























