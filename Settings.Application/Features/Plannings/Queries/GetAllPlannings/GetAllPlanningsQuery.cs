using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Plannings.Queries.GetAllPlannings;
public class GetAllPlanningsQuery : IRequest<IEnumerable<PlanningDTO>>
{

}
