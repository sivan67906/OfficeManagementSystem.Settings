using MediatR;

namespace Settings.Application.Features.Companies.Commands.DeleteCompany
{
    public class DeleteCompanyCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}


