using Settings.Domain.Entities;
using MediatR;

namespace Settings.Application.Features.Countries.Queries.GetCountryById
{
    public class GetCountryByIdQuery : IRequest<CountryDTO>
    {
        public int Id { get; set; }
    }
}













