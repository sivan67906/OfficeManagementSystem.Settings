using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.RecruitNotificationSettings.Commands.CreateRecruitNotificationSetting;

internal class CreateRecruitNotificationSettingCommandHandler(
    IGenericRepository<RecruitNotificationSetting> recruitNotificationSettingRepository) : IRequestHandler<CreateRecruitNotificationSettingCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateRecruitNotificationSettingCommand request, CancellationToken cancellationToken)
    {
        var recruitNotificationSetting = new RecruitNotificationSetting
        {
            CBEMailJsonSettings = request.CBEMailJsonSettings,
            CBEMailNotificationJsonSettings = request.CBEMailNotificationJsonSettings,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await recruitNotificationSettingRepository.CreateAsync(recruitNotificationSetting);
    }
}
























