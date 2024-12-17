﻿using Settings.Domain.Entities;

namespace Settings.Application.Services
{
    public interface ILeadSourceService
    {
        Task<LeadSource> GetByLeadSourceNameAsync(string leadSource);
        Task<IEnumerable<LeadSource>> SearchLeadSourceByNameAsync(string leadSource);
        Task UpdateLeadSourceAsync(LeadSource leadSource);
    }
}
 