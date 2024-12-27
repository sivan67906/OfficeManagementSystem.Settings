using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.CustomQuestionCategories.Commands.DeleteCustomQuestionCategory;

internal class DeleteCustomQuestionCategoryCommandHandler : IRequestHandler<DeleteCustomQuestionCategoryCommand>
{
    private readonly IGenericRepository<CustomQuestionCategory> _customQuestionCategoryRepository;

    public DeleteCustomQuestionCategoryCommandHandler(
        IGenericRepository<CustomQuestionCategory> customQuestionCategoryRepository) =>
        _customQuestionCategoryRepository = customQuestionCategoryRepository;
    public async System.Threading.Tasks.Task Handle(DeleteCustomQuestionCategoryCommand request, CancellationToken cancellationToken)
    {
        await _customQuestionCategoryRepository.DeleteAsync(request.Id);
    }
}
























