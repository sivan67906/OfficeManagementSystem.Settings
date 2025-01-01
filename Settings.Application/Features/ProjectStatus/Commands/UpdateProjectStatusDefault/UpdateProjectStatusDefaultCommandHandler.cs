using MediatR;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.ProjectStatus.Commands.UpdateProjectStatusDefault;
internal class UpdateProjectStatusDefaultCommandHandler : IRequestHandler<UpdateProjectStatusDefaultCommand>
{
    private readonly IGenericRepository<Settings.Domain.Entities.ProjectStatus> _projectStatusRepository;

    public UpdateProjectStatusDefaultCommandHandler(
        IGenericRepository<Settings.Domain.Entities.ProjectStatus> projectStatusRepository)
    {
        _projectStatusRepository = projectStatusRepository;
    }

    public async System.Threading.Tasks.Task Handle(UpdateProjectStatusDefaultCommand request, CancellationToken cancellationToken)
    {
        //var projectStatus = await _projectStatusRepository.GetByIdAsync(request.Id);
        var projectStatus = await _projectStatusRepository.GetAllAsync();

        foreach (var entity in projectStatus)
        {
            if (entity.Id == request.Id)
            {
                entity.Id = request.Id;
                entity.IsDefaultStatus = true;
                entity.UpdatedDate = DateTime.Now;
                await _projectStatusRepository.UpdateAsync(entity);
            }
            else
            {
                entity.IsDefaultStatus = false;
                await _projectStatusRepository.UpdateAsync(entity);
            }
        }
        //var projectStatusUpdate = new Settings.Domain.Entities.ProjectStatus
        //{
        //    Id = projectStatus.Id,
        //    IsDefaultStatus = true,
        //    UpdatedDate = DateTime.Now
        //};
    }
}
