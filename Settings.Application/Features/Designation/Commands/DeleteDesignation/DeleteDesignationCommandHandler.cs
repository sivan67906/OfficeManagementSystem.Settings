using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Designations.Commands.DeleteDesignation;

internal class DeleteDesignationCommandHandler : IRequestHandler<DeleteDesignationCommand>
{
    private readonly IGenericRepository<Designation> _designationRepository;

    public DeleteDesignationCommandHandler(
        IGenericRepository<Designation> designationRepository) =>
        _designationRepository = designationRepository;
    public async System.Threading.Tasks.Task Handle(DeleteDesignationCommand request, CancellationToken cancellationToken)
    {
        await _designationRepository.DeleteAsync(request.Id);
    }
}






