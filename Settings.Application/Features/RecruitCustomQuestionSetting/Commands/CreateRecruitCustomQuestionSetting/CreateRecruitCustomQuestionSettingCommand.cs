using MediatR;

namespace Settings.Application.Features.RecruitCustomQuestionSettings.Commands.CreateRecruitCustomQuestionSetting;

public class CreateRecruitCustomQuestionSettingCommand : IRequest
{
    public string? CQQuestion { get; set; }
    public int CustomQuestionTypeId { get; set; }
    public int CustomQuestionCategoryId { get; set; }
    public int CQStatusId { get; set; }
    public int CQIsRequiredId { get; set; }
}
























