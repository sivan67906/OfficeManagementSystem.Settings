﻿using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Plannings.Queries.GetPlanningById;
public class GetPlanningByIdQueryHandler : IRequestHandler<GetPlanningByIdQuery, PlanningDTO>
{
    private readonly IGenericRepository<Planning> _planrepo;
    public GetPlanningByIdQueryHandler(IGenericRepository<Planning> planrepo)
    {
        _planrepo = planrepo;
    }

    public async Task<PlanningDTO> Handle(GetPlanningByIdQuery request, CancellationToken cancellationToken)
    {
        var plan = await _planrepo.GetByIdAsync(request.Id);
        if (plan == null) return null;
        return new PlanningDTO
        {
            Id = plan.Id,
            Name = plan.Name,
            PlanPrice = plan.PlanPrice,
            Description = plan.Description,
            Validity = plan.Validity,
            Employee = plan.Employee,
            Designation = plan.Designation,
            Department = plan.Department,
            Company = plan.Company,
            Roles = plan.Roles,
            Permission = plan.Permission,
        };
    }
}
