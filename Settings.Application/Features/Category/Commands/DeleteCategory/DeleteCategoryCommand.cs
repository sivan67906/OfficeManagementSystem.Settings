using MediatR;

namespace Settings.Application.Features.Categories.Commands.DeleteCategory
{
    public class DeleteCategoryCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}









