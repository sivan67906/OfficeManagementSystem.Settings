﻿using Settings.Domain.Entities;

namespace Settings.Application.Services
{
    public interface ILeadStatusService
    {
        Task<LeadStatus> GetByLeadStatusNameAsync(string leadStatus);
        Task<IEnumerable<LeadStatus>> SearchLeadStatusByNameAsync(string leadStatus);
        System.Threading.Tasks.Task UpdateLeadStatusAsync(LeadStatus leadStatus);
    }
}
