using MediatR;

namespace Settings.Application.Features.Companies.Commands.DeleteCompany
{
    public class DeleteCompanyCommand : IRequest
    {
        public int Id { get; set; }
    }
}


