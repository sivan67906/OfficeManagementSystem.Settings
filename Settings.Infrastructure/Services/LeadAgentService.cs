﻿using Settings.Application.Services;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Infrastructure.Services
{
    public class LeadAgentService : ILeadAgentService
    {
        private readonly IGenericRepository<Domain.Entities.LeadAgent> _leadAgentRepository;
        public LeadAgentService(IGenericRepository<Domain.Entities.LeadAgent> leadAgentRepository) => leadAgentRepository = _leadAgentRepository;

        public async Task<LeadAgent> GetByLeadAgentNameAsync(string leadAgent)
        {
            var product = await _leadAgentRepository.GetAllAsync();
            return product.FirstOrDefault(
                p => p.AgentName.Equals(leadAgent, StringComparison.OrdinalIgnoreCase));
        }

        public async Task<IEnumerable<LeadAgent>> SearchLeadAgentByNameAsync(string leadAgent)
        {
            var products = await _leadAgentRepository.GetAllAsync();
            return products.Where(
                p => p.AgentName.Contains(leadAgent, StringComparison.OrdinalIgnoreCase));
        }

        public async System.Threading.Tasks.Task UpdateLeadAgentAsync(LeadAgent agent)
        {
            var existingProduct = await _leadAgentRepository.GetByIdAsync(agent.Id);

            if (existingProduct == null)
            {
                throw new KeyNotFoundException($"Product with ID {agent.Id} not found.");
            }

            // Detach the existing product to avoid tracking conflict
            //_productRepository.Detach(existingProduct);

            // Apply changes to the product
            existingProduct.AgentName = agent.AgentName;


            // Call the repository's UpdateAsync method
            await _leadAgentRepository.UpdateAsync(existingProduct);
        }
    }
}
