using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Plannings.Queries.GetAllPlannings;
public class GetAllPlanningsQueryHandler : IRequestHandler<GetAllPlanningsQuery,IEnumerable<PlanningDTO>>
{
    private readonly IGenericRepository<Planning> _planrepo;
    public GetAllPlanningsQueryHandler(IGenericRepository<Planning> planrepo) => _planrepo = planrepo;


    public async Task<IEnumerable<PlanningDTO>> Handle(GetAllPlanningsQuery request, CancellationToken cancellationToken)
    {
        var clients = await _planrepo.GetAllAsync();

        var clientlist = clients.Select(x => new PlanningDTO
        {
            Id = x.Id,
            Name = x.Name,
            PlanPrice = x.PlanPrice,
            Description = x.Description,
            Validity = x.Validity,
            Employee = x.Employee,
            Designation = x.Designation,
            Department = x.Department,
            Company = x.Company,
            Roles = x.Roles,
            Permission = x.Permission,
        }).ToList();

        return clientlist;
    }
}
