using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Cities.Queries.GetCityById
{
    public class GetCityByIdQuery : IRequest<CityDTO>
    {
        public Guid Id { get; set; }
    }
}

















