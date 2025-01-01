using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.States.Queries.GetStateById
{
    public class GetStateByIdQuery : IRequest<StateDTO>
    {
        public Guid Id { get; set; }
    }
}













