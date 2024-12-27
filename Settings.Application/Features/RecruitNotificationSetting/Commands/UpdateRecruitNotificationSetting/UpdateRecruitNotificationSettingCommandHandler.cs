using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.RecruitNotificationSettings.Commands.UpdateRecruitNotificationSetting;

internal class UpdateRecruitNotificationSettingCommandHandler : IRequestHandler<UpdateRecruitNotificationSettingCommand>
{
    private readonly IGenericRepository<RecruitNotificationSetting> _recruitNotificationSettingRepository;

    public UpdateRecruitNotificationSettingCommandHandler(
        IGenericRepository<RecruitNotificationSetting> recruitNotificationSettingRepository) =>
        _recruitNotificationSettingRepository = recruitNotificationSettingRepository;

    public async System.Threading.Tasks.Task Handle(UpdateRecruitNotificationSettingCommand request, CancellationToken cancellationToken)
    {
        var recruitNotificationSetting = new RecruitNotificationSetting
        {
            Id = request.Id,
            CBEMailJsonSettings = request.CBEMailJsonSettings,
            CBEMailNotificationJsonSettings = request.CBEMailNotificationJsonSettings,
            UpdatedDate = DateTime.Now
        };

        await _recruitNotificationSettingRepository.UpdateAsync(recruitNotificationSetting);
    }
}
























