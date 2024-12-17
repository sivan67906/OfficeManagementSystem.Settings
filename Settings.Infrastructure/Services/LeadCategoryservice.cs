﻿using Settings.Application.Services;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Infrastructure.Services
{
    public class LeadCategoryservice : ILeadCategoryService
    {
        private readonly IGenericRepository<Domain.Entities.LeadCategory> _repository;
        public LeadCategoryservice(IGenericRepository<Domain.Entities.LeadCategory> repository) => _repository = repository;

        public async Task<LeadCategory> GetByCategoryNameAsync(string categoryName)
        {
            var product = await _repository.GetAllAsync();
            return product.FirstOrDefault(
                p => p.CategoryName.Equals(categoryName, StringComparison.OrdinalIgnoreCase));
        }

        public async Task<IEnumerable<LeadCategory>> SearchCategoryByNameAsync(string categoryName)
        {
            var products = await _repository.GetAllAsync();
            return products.Where(
                p => p.CategoryName.Contains(categoryName, StringComparison.OrdinalIgnoreCase));
        }

        public async Task UpdateCategoryAsync(LeadCategory category)
        {
            var existingProduct = await _repository.GetByIdAsync(category.Id);

            if (existingProduct == null)
            {
                throw new KeyNotFoundException($"Product with ID {category.Id} not found.");
            }

            // Detach the existing product to avoid tracking conflict
            //_productRepository.Detach(existingProduct);

            // Apply changes to the product
            existingProduct.CategoryName = category.CategoryName;


            // Call the repository's UpdateAsync method
            await _repository.UpdateAsync(existingProduct);
        }
    }
}
