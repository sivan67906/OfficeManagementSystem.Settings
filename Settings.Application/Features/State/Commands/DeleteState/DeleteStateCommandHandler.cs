using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Configuration.Application.Features.States.Commands.DeleteState;

internal class DeleteStateCommandHandler : IRequestHandler<DeleteStateCommand>
{
    private readonly IGenericRepository<State> _stateRepository;

    public DeleteStateCommandHandler(
        IGenericRepository<State> stateRepository) =>
        _stateRepository = stateRepository;
    public async System.Threading.Tasks.Task Handle(DeleteStateCommand request, CancellationToken cancellationToken)
    {
        await _stateRepository.DeleteAsync(request.Id);
    }
}












