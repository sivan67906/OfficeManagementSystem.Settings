using Settings.Application.DTOs;
using MediatR;

namespace Settings.Application.Features.Companies.Queries.GetCompanyById
{
    public class GetCompanyByIdQuery : IRequest<CompanyDTO>
    {
        public Guid Id { get; set; }
    }
}


