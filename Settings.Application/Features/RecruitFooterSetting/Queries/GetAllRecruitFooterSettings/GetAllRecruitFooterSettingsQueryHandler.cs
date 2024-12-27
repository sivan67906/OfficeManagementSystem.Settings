using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.RecruitFooterSettings.Queries.GetAllRecruitFooterSettings;

internal class GetAllRecruitFooterSettingsQueryHandler : IRequestHandler<GetAllRecruitFooterSettingsQuery, IEnumerable<RecruitFooterSettingDTO>>
{
    private readonly IGenericRepository<RecruitFooterSetting> _recruitFooterSettingRepository;
    private readonly IGenericRepository<ProjectReminderPerson> _projectReminderPersonRepository;

    public GetAllRecruitFooterSettingsQueryHandler(
        IGenericRepository<RecruitFooterSetting> recruitFooterSettingRepository,
        IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository)
    {
        _recruitFooterSettingRepository = recruitFooterSettingRepository;
        _projectReminderPersonRepository = projectReminderPersonRepository;
    }

    public async Task<IEnumerable<RecruitFooterSettingDTO>> Handle(GetAllRecruitFooterSettingsQuery request, CancellationToken cancellationToken)
    {
        var recruitFooterSettings = await _recruitFooterSettingRepository.GetAllAsync();

        var recruitFooterSettingList = recruitFooterSettings.Select(x => new RecruitFooterSettingDTO
        {
            Id = x.Id,
            FooterTitle = x.FooterTitle,
            FooterSlug = x.FooterSlug,
            FooterStatusId = x.FooterStatusId,
            FooterDescription = x.FooterDescription
        }).ToList();

        return recruitFooterSettingList;
    }
}
























