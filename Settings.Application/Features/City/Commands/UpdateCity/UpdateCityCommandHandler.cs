using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Cities.Commands.UpdateCity;

internal class UpdateCityCommandHandler : IRequestHandler<UpdateCityCommand>
{
    private readonly IGenericRepository<City> _cityRepository;

    public UpdateCityCommandHandler(
        IGenericRepository<City> cityRepository) =>
        _cityRepository = cityRepository;

    public async System.Threading.Tasks.Task Handle(UpdateCityCommand request, CancellationToken cancellationToken)
    {
        var city = new City
        {
            Id = request.Id,
            Name = request.Name,
            Code = request.Code,
            StateId = request.StateId,
            UpdatedDate = DateTime.UtcNow
        };

        await _cityRepository.UpdateAsync(city);
    }
}

















