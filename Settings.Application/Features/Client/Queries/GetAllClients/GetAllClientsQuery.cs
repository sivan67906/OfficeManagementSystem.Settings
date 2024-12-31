using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Client.Queries.GetAllClients;
public class GetAllClientsQuery : IRequest<IEnumerable<ClientDTO>>
{
}