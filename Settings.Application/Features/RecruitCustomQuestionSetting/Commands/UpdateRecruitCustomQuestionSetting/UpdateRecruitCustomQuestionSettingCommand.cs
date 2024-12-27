using MediatR;

namespace Settings.Application.Features.RecruitCustomQuestionSettings.Commands.UpdateRecruitCustomQuestionSetting;

public class UpdateRecruitCustomQuestionSettingCommand : IRequest
{
    public int Id { get; set; }
    public string? CQQuestion { get; set; }
    public int CustomQuestionTypeId { get; set; }
    public int CustomQuestionCategoryId { get; set; }
    public int CQStatusId { get; set; }
    public int CQIsRequiredId { get; set; }
}
























