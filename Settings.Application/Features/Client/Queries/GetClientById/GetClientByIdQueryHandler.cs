using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Client.Queries.GetClientById;
public class GetClientByIdQueryHandler : IRequestHandler<GetClientByIdQuery, ClientDTO>
{
    private readonly IGenericRepository<Domain.Entities.Client> _repository;
    public GetClientByIdQueryHandler(IGenericRepository<Domain.Entities.Client> repository) => _repository = repository;

    public async Task<ClientDTO> Handle(GetClientByIdQuery request, CancellationToken cancellationToken)
    {
        var client = await _repository.GetByIdAsync(request.Id);
        if (client == null) return null;
        return new ClientDTO
        {
            Id = client.Id,
            ClientName = client.ClientName,
            ClientCode = client.ClientCode,
            Description = client.Description,
            Email = client.Email,
            //CompanyId = client.CompanyId,
            PhoneNumber = client.PhoneNumber,
            Address1 = client.Address1,
            Address2 = client.Address2,
            //CountryId = client.CountryId,
            //StateId = client.StateId,
            //CityId = client.CityId,
            ZipCode = client.ZipCode
        };
    }
}