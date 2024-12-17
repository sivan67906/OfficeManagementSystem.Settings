using Settings.Domain.Entities;

namespace Settings.Application.Services
{
    public interface ILeadCategoryService
    {
        Task<LeadCategory> GetByCategoryNameAsync(string categoryName);
        Task<IEnumerable<LeadCategory>> SearchCategoryByNameAsync(string categoryName);
        Task UpdateCategoryAsync(LeadCategory category);
    }
}
