using MediatR;
using Settings.Application.DTOs;

namespace Configuration.Application.Features.Cities.Queries.GetCityById
{
    public class GetCityByIdQuery : IRequest<CityDTO>
    {
        public int Id { get; set; }
    }
}
















