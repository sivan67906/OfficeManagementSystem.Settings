using MediatR;

namespace Settings.Application.Features.Plannings.Commands.DeletePlanning;
public class DeletePlanningCommand : IRequest
{
    public int Id { get; set; }
}
