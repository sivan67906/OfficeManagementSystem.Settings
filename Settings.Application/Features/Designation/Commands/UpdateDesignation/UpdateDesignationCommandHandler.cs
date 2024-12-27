using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Designations.Commands.UpdateDesignation;

internal class UpdateDesignationCommandHandler : IRequestHandler<UpdateDesignationCommand>
{
    private readonly IGenericRepository<Designation> _designationRepository;

    public UpdateDesignationCommandHandler(
        IGenericRepository<Designation> designationRepository) =>
        _designationRepository = designationRepository;

    public async System.Threading.Tasks.Task Handle(UpdateDesignationCommand request, CancellationToken cancellationToken)
    {
        var designation = new Designation
        {
            Id = request.Id,
            Code = request.Code,
            Name = request.Name,
            CompanyId = request.CompanyId,
            DepartmentId = request.DepartmentId,
            Description = request.Description,
            UpdatedDate = request.UpdatedDate,
            IsActive = request.IsActive
        };

        await _designationRepository.UpdateAsync(designation);
    }
}






