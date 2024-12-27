using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.States.Commands.UpdateState;

internal class UpdateStateCommandHandler : IRequestHandler<UpdateStateCommand>
{
    private readonly IGenericRepository<State> _stateRepository;

    public UpdateStateCommandHandler(
        IGenericRepository<State> stateRepository) =>
        _stateRepository = stateRepository;

    public async System.Threading.Tasks.Task Handle(UpdateStateCommand request, CancellationToken cancellationToken)
    {
        var state = new State
        {
            Id = request.Id,
            Name = request.Name,
            Code = request.Code,
            CountryId = request.CountryId,
            UpdatedDate = request.UpdatedDate
        };

        await _stateRepository.UpdateAsync(state);
    }
}













