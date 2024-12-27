using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Companies.Commands.UpdateCompany;

internal class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommand>
{
    private readonly IGenericRepository<Company> _companyRepository;

    public UpdateCompanyCommandHandler(
        IGenericRepository<Company> companyRepository) =>
        _companyRepository = companyRepository;

    public async System.Threading.Tasks.Task Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
    {
        var company = new Company
        {
            Id = request.Id,
            Name = request.Name,
            RegnNumber = request.RegnNumber,
            Email = request.Email,
            PhoneNumber = request.PhoneNumber,
            EstablishedYear = request.EstablishedYear,
            Website = request.Website,
            BusinessTypeId = request.BusinessTypeId,
            CategoryId = request.CategoryId,
            Description = request.Description,
            UpdatedDate = DateTime.Now
        };

        await _companyRepository.UpdateAsync(company);
    }
}


