using MediatR;

namespace Settings.Application.Features.JobApplicationCategories.Commands.DeleteJobApplicationCategory
{
    public class DeleteJobApplicationCategoryCommand : IRequest
    {
        public int Id { get; set; }
    }
}
























