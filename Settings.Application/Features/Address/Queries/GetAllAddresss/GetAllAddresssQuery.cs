using MediatR;
using Settings.Application.DTOs;

namespace Configuration.Application.Features.Addresses.Queries.GetAllAddresses;

public class GetAllAddressesQuery : IRequest<IEnumerable<AddressDTO>>
{
}












