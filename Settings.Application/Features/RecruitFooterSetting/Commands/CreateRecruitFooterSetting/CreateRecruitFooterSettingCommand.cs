using MediatR;

namespace Settings.Application.Features.RecruitFooterSettings.Commands.CreateRecruitFooterSetting;

public class CreateRecruitFooterSettingCommand : IRequest
{
    public string? FooterTitle { get; set; }
    public string? FooterSlug { get; set; }
    public int FooterStatusId { get; set; }
    public string? FooterStatusName { get; set; }
    public string? FooterDescription { get; set; }
}
























