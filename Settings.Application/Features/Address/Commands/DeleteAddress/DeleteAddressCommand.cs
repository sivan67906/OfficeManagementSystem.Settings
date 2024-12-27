using MediatR;

namespace Settings.Application.Features.Addresses.Commands.DeleteAddress
{
    public class DeleteAddressCommand : IRequest
    {
        public int Id { get; set; }
    }
}













