using MediatR;

namespace Settings.Application.Features.Countries.Commands.DeleteCountry
{
    public class DeleteCountryCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}













