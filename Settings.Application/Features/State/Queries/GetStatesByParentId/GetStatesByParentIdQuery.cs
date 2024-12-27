using Settings.Application.DTOs;
using MediatR;

namespace Settings.Application.Features.States.Queries.GetStatesByParentId;
public class GetStatesByParentIdQuery : IRequest<IEnumerable<StateDTO>>
{
    public int CountryId { get; set; }
}

