//using Microsoft.EntityFrameworkCore;
using Settings.Domain.Contracts.Lead;
using Settings.Domain.Entities;
using Settings.Infrastructure.Persistence;

namespace Settings.Infrastructure.Repositories;

public class LeadCategoryRepository(ApplicationDbContext dbContext) 
    : GenericRepository<LeadCategory>(dbContext, dbContext.LeadCategories), ILeadCategory
{

}