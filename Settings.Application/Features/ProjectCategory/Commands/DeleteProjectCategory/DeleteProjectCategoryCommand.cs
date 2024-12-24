using MediatR;

namespace Settings.Application.Features.ProjectCategories.Commands.DeleteProjectCategory
{
    public class DeleteProjectCategoryCommand : IRequest
    {
        public int Id { get; set; }
    }
}












