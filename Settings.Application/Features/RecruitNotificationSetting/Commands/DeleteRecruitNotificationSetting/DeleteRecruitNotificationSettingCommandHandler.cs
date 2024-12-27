using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.RecruitNotificationSettings.Commands.DeleteRecruitNotificationSetting;

internal class DeleteRecruitNotificationSettingCommandHandler : IRequestHandler<DeleteRecruitNotificationSettingCommand>
{
    private readonly IGenericRepository<RecruitNotificationSetting> _recruitNotificationSettingRepository;

    public DeleteRecruitNotificationSettingCommandHandler(
        IGenericRepository<RecruitNotificationSetting> recruitNotificationSettingRepository) =>
        _recruitNotificationSettingRepository = recruitNotificationSettingRepository;
    public async System.Threading.Tasks.Task Handle(DeleteRecruitNotificationSettingCommand request, CancellationToken cancellationToken)
    {
        await _recruitNotificationSettingRepository.DeleteAsync(request.Id);
    }
}
























