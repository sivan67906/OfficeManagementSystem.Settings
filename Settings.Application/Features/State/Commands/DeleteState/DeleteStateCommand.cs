using MediatR;

namespace Settings.Application.Features.States.Commands.DeleteState
{
    public class DeleteStateCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}













