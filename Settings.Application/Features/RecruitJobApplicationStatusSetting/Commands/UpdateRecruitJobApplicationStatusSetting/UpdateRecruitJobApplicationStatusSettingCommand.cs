using MediatR;

namespace Settings.Application.Features.RecruitJobApplicationStatusSettings.Commands.UpdateRecruitJobApplicationStatusSetting;

public class UpdateRecruitJobApplicationStatusSettingCommand : IRequest
{
    public Guid Id { get; set; }
    public int JobApplicationPositionId { get; set; }
    public int JobApplicationCategoryId { get; set; }
    public string? JASStatus { get; set; }
    public string? JASColor { get; set; }
    public int JASIsModelChecked { get; set; }
}
























