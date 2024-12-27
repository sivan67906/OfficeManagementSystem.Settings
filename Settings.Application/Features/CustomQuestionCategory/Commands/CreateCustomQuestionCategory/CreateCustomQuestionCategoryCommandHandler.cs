using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.CustomQuestionCategories.Commands.CreateCustomQuestionCategory;

internal class CreateCustomQuestionCategoryCommandHandler(
    IGenericRepository<CustomQuestionCategory> customQuestionCategoryRepository) : IRequestHandler<CreateCustomQuestionCategoryCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateCustomQuestionCategoryCommand request, CancellationToken cancellationToken)
    {
        var customQuestionCategory = new CustomQuestionCategory
        {
            CQCategoryCode = request.CQCategoryCode,
            CQCategoryName = request.CQCategoryName,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await customQuestionCategoryRepository.CreateAsync(customQuestionCategory);
    }
}
























