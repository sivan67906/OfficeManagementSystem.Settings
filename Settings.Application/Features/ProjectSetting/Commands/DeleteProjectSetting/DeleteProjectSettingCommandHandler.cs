using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.ProjectSettings.Commands.DeleteProjectSetting;

internal class DeleteProjectSettingCommandHandler : IRequestHandler<DeleteProjectSettingCommand>
{
    private readonly IGenericRepository<ProjectSetting> _projectSettingRepository;

    public DeleteProjectSettingCommandHandler(
        IGenericRepository<ProjectSetting> projectSettingRepository) =>
        _projectSettingRepository = projectSettingRepository;
    public async System.Threading.Tasks.Task Handle(DeleteProjectSettingCommand request, CancellationToken cancellationToken)
    {
        await _projectSettingRepository.DeleteAsync(request.Id);
    }
}




















