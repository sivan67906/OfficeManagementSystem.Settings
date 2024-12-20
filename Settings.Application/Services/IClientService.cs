using Settings.Domain.Entities;

namespace Settings.Application.Services
{
    public interface IClientService
    {
        Task<Client> GetByLeadAgentNameAsync(string client);
        Task<IEnumerable<Client>> SearchLeadAgentByNameAsync(string client);
        System.Threading.Tasks.Task UpdateLeadAgentAsync(Client client);
    }
}
