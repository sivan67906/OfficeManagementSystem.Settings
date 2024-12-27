using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.RecruitFooterSettings.Queries.GetRecruitFooterSettingById;

internal class GetRecruitFooterSettingByIdQueryHandler : IRequestHandler<GetRecruitFooterSettingByIdQuery, RecruitFooterSettingDTO>
{
    private readonly IGenericRepository<RecruitFooterSetting> _recruitFooterSettingRepository;

    public GetRecruitFooterSettingByIdQueryHandler(
        IGenericRepository<RecruitFooterSetting> recruitFooterSettingRepository) =>
        _recruitFooterSettingRepository = recruitFooterSettingRepository;

    public async Task<RecruitFooterSettingDTO> Handle(GetRecruitFooterSettingByIdQuery request, CancellationToken cancellationToken)
    {
        var recruitFooterSetting = await _recruitFooterSettingRepository.GetByIdAsync(request.Id);
        if (recruitFooterSetting == null) return null;
        return new RecruitFooterSettingDTO
        {
            Id = recruitFooterSetting.Id,
            FooterTitle = recruitFooterSetting.FooterTitle,
            FooterSlug = recruitFooterSetting.FooterSlug,
            FooterStatusId = recruitFooterSetting.FooterStatusId,
            FooterDescription = recruitFooterSetting.FooterDescription
        };
    }
}
























