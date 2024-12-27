using MediatR;

namespace Settings.Application.Features.IsToggleTypes.Commands.DeleteIsToggleType
{
    public class DeleteIsToggleTypeCommand : IRequest
    {
        public int Id { get; set; }
    }
}




























