using MediatR;

namespace Settings.Application.Features.Plannings.Commands.DeletePlanning;
public class DeletePlanningCommand : IRequest
{
    public Guid Id { get; set; }
}
