using Settings.Domain.Entities;
using Settings.Domain.Interfaces;
using MediatR;

namespace Settings.Application.Features.Categories.Commands.CreateCategory;

internal class CreateCategoryCommandHandler(
    IGenericRepository<Category> categoryRepository) : IRequestHandler<CreateCategoryCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = new Category
        {

        };

        await categoryRepository.CreateAsync(category);
    }
}









