using MediatR;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.ProjectStatuses.Commands.UpdateProjectStatus;

internal class UpdateProjectStatusCommandHandler : IRequestHandler<UpdateProjectStatusCommand>
{
    private readonly IGenericRepository<Settings.Domain.Entities.ProjectStatus> _projectStatusRepository;

    public UpdateProjectStatusCommandHandler(
        IGenericRepository<Settings.Domain.Entities.ProjectStatus> projectStatusRepository) =>
        _projectStatusRepository = projectStatusRepository;

    public async System.Threading.Tasks.Task Handle(UpdateProjectStatusCommand request, CancellationToken cancellationToken)
    {

        if (request.IsDefaultStatus == true)
        {
            var projectStatusExistUpdate = await _projectStatusRepository.GetAllAsync();

            foreach (var entity in projectStatusExistUpdate)
            {
                if (entity.Id == request.Id)
                {
                    entity.Id = request.Id;
                    entity.Name = request.Name;
                    entity.ColorCode = request.ColorCode;
                    entity.IsDefaultStatus = request.IsDefaultStatus;
                    entity.Status = request.Status;
                    entity.UpdatedDate = DateTime.Now;
                    await _projectStatusRepository.UpdateAsync(entity);
                }
                else
                {
                    entity.IsDefaultStatus = false;
                    await _projectStatusRepository.UpdateAsync(entity);
                }
            }
        }
        else
        {
            var projectStatus = new Settings.Domain.Entities.ProjectStatus
            {
                Id = request.Id,
                Name = request.Name,
                ColorCode = request.ColorCode,
                IsDefaultStatus = request.IsDefaultStatus,
                Status = request.Status,
                UpdatedDate = DateTime.Now
            };

            await _projectStatusRepository.UpdateAsync(projectStatus);
        }





    }
}
















