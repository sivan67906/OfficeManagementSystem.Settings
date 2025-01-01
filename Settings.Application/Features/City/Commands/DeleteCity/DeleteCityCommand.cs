using MediatR;

namespace Settings.Application.Features.Cities.Commands.DeleteCity
{
    public class DeleteCityCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}

















