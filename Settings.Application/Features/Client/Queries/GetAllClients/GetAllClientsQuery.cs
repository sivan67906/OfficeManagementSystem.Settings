using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Client.Queries.GetAllClients;
public class GetAllClientsQuery : IRequest<IEnumerable<ClientDTO>>
{
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
}