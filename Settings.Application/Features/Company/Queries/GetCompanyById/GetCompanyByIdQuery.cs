using Settings.Application.DTOs;
using MediatR;

namespace Settings.Application.Features.Companies.Queries.GetCompanyById
{
    public class GetCompanyByIdQuery : IRequest<CompanyDTO>
    {
        public int Id { get; set; }
    }
}


