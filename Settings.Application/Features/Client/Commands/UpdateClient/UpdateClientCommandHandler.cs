using MediatR;
using Settings.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Settings.Application.Features.Client.Commands.UpdateClient;
public class UpdateClientCommandHandler : IRequestHandler<UpdateClientCommand, int>
{
    private readonly IGenericRepository<Domain.Entities.Client> _repository;
    public UpdateClientCommandHandler(IGenericRepository<Domain.Entities.Client> repository) => _repository = repository;

    public async Task<int> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
    {
        var product = new Domain.Entities.Client
        {
            Id = request.Id,
            ClientName = request.ClientName,
            ClientCode = request.ClientCode,
            Description = request.Description,
            Email = request.Email,
           // CompanyId = request.CompanyId,
            PhoneNumber = request.PhoneNumber,
            Address1 = request.Address1,
            Address2 = request.Address2,
            //CountryId = request.CountryId,
            //StateId = request.StateId,
           // CityId = request.CityId,
            ZipCode = request.ZipCode
        };
        await _repository.UpdateAsync(product);
        return request.Id;
    }
}