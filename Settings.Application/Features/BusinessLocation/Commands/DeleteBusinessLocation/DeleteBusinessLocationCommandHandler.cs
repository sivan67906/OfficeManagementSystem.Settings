using Settings.Domain.Entities;
using Settings.Domain.Interfaces;
using MediatR;

namespace Settings.Application.Features.BusinessLocations.Commands.DeleteBusinessLocation;

internal class DeleteBusinessLocationCommandHandler : IRequestHandler<DeleteBusinessLocationCommand>
{
    private readonly IGenericRepository<BusinessLocation> _businessLocationRepository;

    public DeleteBusinessLocationCommandHandler(
        IGenericRepository<BusinessLocation> businessLocationRepository) =>
        _businessLocationRepository = businessLocationRepository;
    public async System.Threading.Tasks.Task Handle(DeleteBusinessLocationCommand request, CancellationToken cancellationToken)
    {
        await _businessLocationRepository.DeleteAsync(request.Id);
    }
}

