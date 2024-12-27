using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.States.Commands.CreateState;

internal class CreateStateCommandHandler(
    IGenericRepository<State> stateRepository) : IRequestHandler<CreateStateCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateStateCommand request, CancellationToken cancellationToken)
    {
        var state = new State
        {
            Code = request.Code,
            Name = request.Name,
            CountryId = request.CountryId,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await stateRepository.CreateAsync(state);
    }
}













