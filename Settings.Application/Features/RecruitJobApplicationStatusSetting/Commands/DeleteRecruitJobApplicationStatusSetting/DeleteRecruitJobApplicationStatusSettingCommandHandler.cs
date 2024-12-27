using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.RecruitJobApplicationStatusSettings.Commands.DeleteRecruitJobApplicationStatusSetting;

internal class DeleteRecruitJobApplicationStatusSettingCommandHandler : IRequestHandler<DeleteRecruitJobApplicationStatusSettingCommand>
{
    private readonly IGenericRepository<RecruitJobApplicationStatusSetting> _recruitJobApplicationStatusSettingRepository;

    public DeleteRecruitJobApplicationStatusSettingCommandHandler(
        IGenericRepository<RecruitJobApplicationStatusSetting> recruitJobApplicationStatusSettingRepository) =>
        _recruitJobApplicationStatusSettingRepository = recruitJobApplicationStatusSettingRepository;
    public async System.Threading.Tasks.Task Handle(DeleteRecruitJobApplicationStatusSettingCommand request, CancellationToken cancellationToken)
    {
        await _recruitJobApplicationStatusSettingRepository.DeleteAsync(request.Id);
    }
}
























