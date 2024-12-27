using MediatR;
using Settings.Application.Features.Companies.Commands.DeleteCompany;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Companys.Commands.DeleteCompany;

internal class DeleteCompanyCommandHandler : IRequestHandler<DeleteCompanyCommand>
{
    private readonly IGenericRepository<Company> _companyRepository;

    public DeleteCompanyCommandHandler(
        IGenericRepository<Company> companyRepository) =>
        _companyRepository = companyRepository;
    public async System.Threading.Tasks.Task Handle(DeleteCompanyCommand request, CancellationToken cancellationToken)
    {
        await _companyRepository.DeleteAsync(request.Id);
    }
}


