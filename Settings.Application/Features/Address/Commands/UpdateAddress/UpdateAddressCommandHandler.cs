using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Configuration.Application.Features.Addresses.Commands.UpdateAddress;

internal class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommand>
{
    private readonly IGenericRepository<Address> _addressRepository;

    public UpdateAddressCommandHandler(
        IGenericRepository<Address> addressRepository) =>
        _addressRepository = addressRepository;

    public async System.Threading.Tasks.Task Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
    {
        var address = new Address
        {
            Id = request.Id,
            Address1 = request.Address1,
            Address2 = request.Address2,
            ZipCode = request.ZipCode,

            CityId = request.CityId,

            UpdatedDate = request.UpdatedDate
        };

        await _addressRepository.UpdateAsync(address);
    }
}












