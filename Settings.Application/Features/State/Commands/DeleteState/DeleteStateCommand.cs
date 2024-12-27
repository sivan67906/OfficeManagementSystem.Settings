using MediatR;

namespace Settings.Application.Features.States.Commands.DeleteState
{
    public class DeleteStateCommand : IRequest
    {
        public int Id { get; set; }
    }
}













