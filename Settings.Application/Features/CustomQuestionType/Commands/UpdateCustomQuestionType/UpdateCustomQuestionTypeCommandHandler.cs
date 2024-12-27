using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.CustomQuestionTypes.Commands.UpdateCustomQuestionType;

internal class UpdateCustomQuestionTypeCommandHandler : IRequestHandler<UpdateCustomQuestionTypeCommand>
{
    private readonly IGenericRepository<CustomQuestionType> _customQuestionTypeRepository;

    public UpdateCustomQuestionTypeCommandHandler(
        IGenericRepository<CustomQuestionType> customQuestionTypeRepository) =>
        _customQuestionTypeRepository = customQuestionTypeRepository;

    public async System.Threading.Tasks.Task Handle(UpdateCustomQuestionTypeCommand request, CancellationToken cancellationToken)
    {
        var customQuestionType = new CustomQuestionType
        {
            Id = request.Id,
            CQTypeCode = request.CQTypeCode,
            CQTypeName = request.CQTypeName,
            UpdatedDate = DateTime.Now
        };

        await _customQuestionTypeRepository.UpdateAsync(customQuestionType);
    }
}
























