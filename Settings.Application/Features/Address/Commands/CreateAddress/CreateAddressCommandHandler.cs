using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Configuration.Application.Features.Addresses.Commands.CreateAddress;

internal class CreateAddressCommandHandler(
    IGenericRepository<Address> addressRepository) : IRequestHandler<CreateAddressCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateAddressCommand request, CancellationToken cancellationToken)
    {
        var address = new Address
        {
            Address1 = request.Address1,
            Address2 = request.Address2,
            ZipCode = request.ZipCode,

            CityId = request.CityId,

            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await addressRepository.CreateAsync(address);
    }
}












