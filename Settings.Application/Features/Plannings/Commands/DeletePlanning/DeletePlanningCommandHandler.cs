using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Plannings.Commands.DeletePlanning;
public class DeletePlanningCommandHandler : IRequestHandler<DeletePlanningCommand>
{
    private readonly IGenericRepository<Planning> _planrepo;
    public DeletePlanningCommandHandler(IGenericRepository<Planning> planrepo) => _planrepo = planrepo;

    public async System.Threading.Tasks.Task Handle(DeletePlanningCommand request, CancellationToken cancellationToken)
    {
        if (request == null || request.Id == null)
        {
            throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
        }

        await _planrepo.DeleteAsync(request.Id);
    }
}
