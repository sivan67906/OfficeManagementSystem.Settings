using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.RecruitNotificationSettings.Queries.GetAllRecruitNotificationSettings;

internal class GetAllRecruitNotificationSettingsQueryHandler : IRequestHandler<GetAllRecruitNotificationSettingsQuery, IEnumerable<RecruitNotificationSettingDTO>>
{
    private readonly IGenericRepository<RecruitNotificationSetting> _recruitNotificationSettingRepository;
    private readonly IGenericRepository<ProjectReminderPerson> _projectReminderPersonRepository;

    public GetAllRecruitNotificationSettingsQueryHandler(
        IGenericRepository<RecruitNotificationSetting> recruitNotificationSettingRepository,
        IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository)
    {
        _recruitNotificationSettingRepository = recruitNotificationSettingRepository;
        _projectReminderPersonRepository = projectReminderPersonRepository;
    }

    public async Task<IEnumerable<RecruitNotificationSettingDTO>> Handle(GetAllRecruitNotificationSettingsQuery request, CancellationToken cancellationToken)
    {
        var recruitNotificationSettings = await _recruitNotificationSettingRepository.GetAllAsync();

        var recruitNotificationSettingList = recruitNotificationSettings.Select(x => new RecruitNotificationSettingDTO
        {
            Id = x.Id,
            CBEMailJsonSettings = x.CBEMailJsonSettings,
            CBEMailNotificationJsonSettings = x.CBEMailNotificationJsonSettings
        }).ToList();

        return recruitNotificationSettingList;
    }
}
























