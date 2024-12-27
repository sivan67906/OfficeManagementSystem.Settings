using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.IsToggleTypes.Commands.CreateIsToggleType;

internal class CreateIsToggleTypeCommandHandler(
    IGenericRepository<IsToggleType> isToggleTypeRepository) : IRequestHandler<CreateIsToggleTypeCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateIsToggleTypeCommand request, CancellationToken cancellationToken)
    {
        var isToggleType = new IsToggleType
        {
            CQTypeCode = request.CQTypeCode,
            CQTypeName = request.CQTypeName,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await isToggleTypeRepository.CreateAsync(isToggleType);
    }
}




























