using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.IsToggleTypes.Commands.DeleteIsToggleType;

internal class DeleteIsToggleTypeCommandHandler : IRequestHandler<DeleteIsToggleTypeCommand>
{
    private readonly IGenericRepository<IsToggleType> _isToggleTypeRepository;

    public DeleteIsToggleTypeCommandHandler(
        IGenericRepository<IsToggleType> isToggleTypeRepository) =>
        _isToggleTypeRepository = isToggleTypeRepository;
    public async System.Threading.Tasks.Task Handle(DeleteIsToggleTypeCommand request, CancellationToken cancellationToken)
    {
        await _isToggleTypeRepository.DeleteAsync(request.Id);
    }
}




























