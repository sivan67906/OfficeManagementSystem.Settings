using Settings.Application.DTOs;
using MediatR;

namespace Settings.Application.Features.BusinessLocations.Queries.GetBusinessLocationById
{
    public class GetBusinessLocationByIdQuery : IRequest<BusinessLocationDTO>
    {
        public Guid Id { get; set; }
    }
}

