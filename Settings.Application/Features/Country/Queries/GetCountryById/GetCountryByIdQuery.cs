using MediatR;
using Settings.Application.DTOs;

namespace Configuration.Application.Features.Countries.Queries.GetCountryById
{
    public class GetCountryByIdQuery : IRequest<CountryDTO>
    {
        public int Id { get; set; }
    }
}












