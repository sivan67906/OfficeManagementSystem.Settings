using MediatR;

namespace Settings.Application.Features.ProjectCategories.Commands.DeleteProjectCategory
{
    public class DeleteProjectCategoryCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}












