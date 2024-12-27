using Settings.Application.DTOs;
using MediatR;

namespace Settings.Application.Features.Companies.Queries.GetAllCompanies;

public class GetAllCompaniesQuery : IRequest<IEnumerable<CompanyDTO>>
{
}


