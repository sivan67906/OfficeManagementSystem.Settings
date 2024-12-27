using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Cities.Commands.DeleteCity;

internal class DeleteCityCommandHandler : IRequestHandler<DeleteCityCommand>
{
    private readonly IGenericRepository<City> _cityRepository;

    public DeleteCityCommandHandler(
        IGenericRepository<City> cityRepository) =>
        _cityRepository = cityRepository;
    public async System.Threading.Tasks.Task Handle(DeleteCityCommand request, CancellationToken cancellationToken)
    {
        await _cityRepository.DeleteAsync(request.Id);
    }
}

















