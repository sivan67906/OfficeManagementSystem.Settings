using Settings.Application.DTOs;
using MediatR;

namespace Settings.Application.Features.Addresses.Queries.GetAddressById
{
    public class GetAddressByIdQuery : IRequest<AddressDTO>
    {
        public Guid Id { get; set; }
    }
}













