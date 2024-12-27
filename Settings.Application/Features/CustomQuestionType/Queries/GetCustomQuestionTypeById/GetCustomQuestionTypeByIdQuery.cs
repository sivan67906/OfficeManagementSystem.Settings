//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.CustomQuestionTypes.Queries.GetCustomQuestionTypeById
{
    public class GetCustomQuestionTypeByIdQuery : IRequest<CustomQuestionTypeDTO>
    {
        public int Id { get; set; }
    }
}
























