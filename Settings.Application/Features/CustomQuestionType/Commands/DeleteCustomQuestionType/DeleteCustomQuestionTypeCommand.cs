using MediatR;

namespace Settings.Application.Features.CustomQuestionTypes.Commands.DeleteCustomQuestionType
{
    public class DeleteCustomQuestionTypeCommand : IRequest
    {
        public int Id { get; set; }
    }
}
























