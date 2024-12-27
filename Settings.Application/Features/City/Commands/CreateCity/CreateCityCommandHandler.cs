using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Cities.Commands.CreateCity;

internal class CreateCityCommandHandler(
    IGenericRepository<City> cityRepository) : IRequestHandler<CreateCityCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateCityCommand request, CancellationToken cancellationToken)
    {
        var city = new City
        {
            Code = request.Code,
            Name = request.Name,
            StateId = request.StateId,
            CreatedDate = DateTime.UtcNow,
            IsActive = true
        };

        await cityRepository.CreateAsync(city);
    }
}

















