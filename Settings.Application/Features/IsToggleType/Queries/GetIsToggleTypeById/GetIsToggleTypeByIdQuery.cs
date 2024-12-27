//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.IsToggleTypes.Queries.GetIsToggleTypeById
{
    public class GetIsToggleTypeByIdQuery : IRequest<IsToggleTypeDTO>
    {
        public int Id { get; set; }
    }
}




























