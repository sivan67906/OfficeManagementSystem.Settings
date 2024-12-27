using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.RecruitNotificationSettings.Queries.GetRecruitNotificationSettingById;

internal class GetRecruitNotificationSettingByIdQueryHandler : IRequestHandler<GetRecruitNotificationSettingByIdQuery, RecruitNotificationSettingDTO>
{
    private readonly IGenericRepository<RecruitNotificationSetting> _recruitNotificationSettingRepository;

    public GetRecruitNotificationSettingByIdQueryHandler(
        IGenericRepository<RecruitNotificationSetting> recruitNotificationSettingRepository) =>
        _recruitNotificationSettingRepository = recruitNotificationSettingRepository;

    public async Task<RecruitNotificationSettingDTO> Handle(GetRecruitNotificationSettingByIdQuery request, CancellationToken cancellationToken)
    {
        var recruitNotificationSetting = await _recruitNotificationSettingRepository.GetByIdAsync(request.Id);
        if (recruitNotificationSetting == null) return null;
        return new RecruitNotificationSettingDTO
        {
            Id = recruitNotificationSetting.Id,
            CBEMailJsonSettings = recruitNotificationSetting.CBEMailJsonSettings,
            CBEMailNotificationJsonSettings = recruitNotificationSetting.CBEMailNotificationJsonSettings
        };
    }
}
























