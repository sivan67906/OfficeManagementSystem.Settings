using MediatR;

namespace Settings.Application.Features.RecruitFooterSettings.Commands.UpdateRecruitFooterSetting;

public class UpdateRecruitFooterSettingCommand : IRequest
{
    public Guid Id { get; set; }
    public string? FooterTitle { get; set; }
    public string? FooterSlug { get; set; }
    public int FooterStatusId { get; set; }
    public string? FooterDescription { get; set; }
}
























