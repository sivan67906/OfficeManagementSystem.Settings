using MediatR;
using Settings.Application.DTOs;

namespace Configuration.Application.Features.Addresses.Queries.GetAddressById
{
    public class GetAddressByIdQuery : IRequest<AddressDTO>
    {
        public int Id { get; set; }
    }
}












