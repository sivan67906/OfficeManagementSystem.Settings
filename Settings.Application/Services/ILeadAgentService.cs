using Settings.Domain.Entities;

namespace Settings.Application.Services
{
    public interface ILeadAgentService
    {
        Task<LeadAgent> GetByLeadAgentNameAsync(string leadAgent);
        Task<IEnumerable<LeadAgent>> SearchLeadAgentByNameAsync(string leadAgent);
        Task UpdateLeadAgentAsync(LeadAgent agent);
    }
}
