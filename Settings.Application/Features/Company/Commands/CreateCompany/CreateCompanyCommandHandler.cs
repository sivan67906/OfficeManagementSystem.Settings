using MediatR;
using Settings.Application.Features.Companies.Commands.CreateCompany;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Companys.Commands.CreateCompany;

internal class CreateCompanyCommandHandler(
    IGenericRepository<Company> companyRepository) : IRequestHandler<CreateCompanyCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
    {
        var company = new Company
        {
            Name = request.Name,
            RegnNumber = request.RegnNumber,
            Email = request.Email,
            PhoneNumber = request.PhoneNumber,
            EstablishedYear = request.EstablishedYear,
            Website = request.Website,
            BusinessTypeId = request.BusinessTypeId,
            CategoryId = request.CategoryId,
            Description = request.Description,
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,
            IsActive = request.IsActive
        };

        await companyRepository.CreateAsync(company);
    }
}


