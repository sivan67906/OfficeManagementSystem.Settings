using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Client.Commands.CreateClient;
public class CreateClientCommandHandler(
    IGenericRepository<Domain.Entities.Client> clientRepository,
    IGenericRepository<Address> addressRepository

    ) : IRequestHandler<CreateClientCommand, int>
{
    public async Task<int> Handle(CreateClientCommand request, CancellationToken cancellationToken)
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
        var insertedAddress = await addressRepository.CreateAsyncwithEntity(address);

        var client = new Domain.Entities.Client
        {
            ClientName = request.ClientName,
            ClientCode = request.ClientCode,
            Description = request.Description,
            Email = request.Email,
            CompanyId = request.CompanyId,
            PhoneNumber = request.PhoneNumber,
            AddressId = request.AddressId,
            CountryId = request.CountryId,
            StateId = request.StateId,
            CityId = request.CityId,
        };
        await clientRepository.CreateAsync(client);
        return client.Id;

    }


}
