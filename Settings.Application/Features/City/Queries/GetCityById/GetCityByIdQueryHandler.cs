using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Cities.Queries.GetCityById;

internal class GetCityByIdQueryHandler : IRequestHandler<GetCityByIdQuery, CityDTO>
{
    private readonly IGenericRepository<CityDTO> _cityRepository;

    public GetCityByIdQueryHandler(
        IGenericRepository<CityDTO> cityRepository) =>
        _cityRepository = cityRepository;

    public async Task<CityDTO> Handle(GetCityByIdQuery request, CancellationToken cancellationToken)
    {
        var city = await _cityRepository.GetByIdAsync(request.Id);
        if (city == null) return null;
        return new CityDTO
        {
            Id = city.Id,
            Name = city.Name,
            Code = city.Code,
            StateId = city.StateId,
            CreatedDate = city.CreatedDate
        };
    }
}

















