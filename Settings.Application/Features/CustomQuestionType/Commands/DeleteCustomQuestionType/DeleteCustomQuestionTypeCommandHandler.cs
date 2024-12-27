using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.CustomQuestionTypes.Commands.DeleteCustomQuestionType;

internal class DeleteCustomQuestionTypeCommandHandler : IRequestHandler<DeleteCustomQuestionTypeCommand>
{
    private readonly IGenericRepository<CustomQuestionType> _customQuestionTypeRepository;

    public DeleteCustomQuestionTypeCommandHandler(
        IGenericRepository<CustomQuestionType> customQuestionTypeRepository) =>
        _customQuestionTypeRepository = customQuestionTypeRepository;
    public async System.Threading.Tasks.Task Handle(DeleteCustomQuestionTypeCommand request, CancellationToken cancellationToken)
    {
        await _customQuestionTypeRepository.DeleteAsync(request.Id);
    }
}
























