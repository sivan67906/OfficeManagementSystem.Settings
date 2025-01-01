using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Plannings.Queries.GetPlanningById;
public class GetPlanningByIdQuery : IRequest<PlanningDTO>
{
    public Guid Id { get; set; }
}
