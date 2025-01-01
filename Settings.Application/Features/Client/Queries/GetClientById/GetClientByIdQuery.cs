using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Client.Queries.GetClientById;
public class GetClientByIdQuery : IRequest<ClientDTO>
{
    public Guid Id { get; set; }
}