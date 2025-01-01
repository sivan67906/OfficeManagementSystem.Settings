using MediatR;

namespace Settings.Application.Features.CustomQuestionTypes.Commands.DeleteCustomQuestionType
{
    public class DeleteCustomQuestionTypeCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
























