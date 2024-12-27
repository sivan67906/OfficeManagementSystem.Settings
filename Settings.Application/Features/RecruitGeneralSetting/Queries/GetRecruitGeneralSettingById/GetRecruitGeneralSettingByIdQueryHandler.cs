using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.RecruitGeneralSettings.Queries.GetRecruitGeneralSettingById;

internal class GetRecruitGeneralSettingByIdQueryHandler : IRequestHandler<GetRecruitGeneralSettingByIdQuery, RecruitGeneralSettingDTO>
{
    private readonly IGenericRepository<RecruitGeneralSetting> _recruitGeneralSettingRepository;

    public GetRecruitGeneralSettingByIdQueryHandler(
        IGenericRepository<RecruitGeneralSetting> recruitGeneralSettingRepository) =>
        _recruitGeneralSettingRepository = recruitGeneralSettingRepository;

    public async Task<RecruitGeneralSettingDTO> Handle(GetRecruitGeneralSettingByIdQuery request, CancellationToken cancellationToken)
    {
        var recruitGeneralSetting = await _recruitGeneralSettingRepository.GetByIdAsync(request.Id);
        if (recruitGeneralSetting == null) return null;
        return new RecruitGeneralSettingDTO
        {
            Id = recruitGeneralSetting.Id,
            GeneralCompanyName = recruitGeneralSetting.GeneralCompanyName,
            GeneralCompanyWebsite = recruitGeneralSetting.GeneralCompanyWebsite,
            GeneralCompanyLogo = recruitGeneralSetting.GeneralCompanyLogo,
            GeneralCompanyLogoPath = recruitGeneralSetting.GeneralCompanyLogoPath,
            GeneralCompanyLogoImageFileName = recruitGeneralSetting.GeneralCompanyLogoImageFileName,
            GeneralAboutCompany = recruitGeneralSetting.GeneralAboutCompany,
            GeneralLegalTerm = recruitGeneralSetting.GeneralLegalTerm,
            GeneralDuplJobApplnRestrictDays = recruitGeneralSetting.GeneralDuplJobApplnRestrictDays,
            GeneralOLReminderToCandidate = recruitGeneralSetting.GeneralOLReminderToCandidate,
            GeneralBGLogo = recruitGeneralSetting.GeneralBGLogo,
            GeneralBGLogoPath = recruitGeneralSetting.GeneralBGLogoPath,
            GeneralBGLogoImageFileName = recruitGeneralSetting.GeneralBGLogoImageFileName,
            GeneralBGColorCode = recruitGeneralSetting.GeneralBGColorCode,
            GeneralCBJsonSettings = recruitGeneralSetting.GeneralCBJsonSettings
        };
    }
}
























