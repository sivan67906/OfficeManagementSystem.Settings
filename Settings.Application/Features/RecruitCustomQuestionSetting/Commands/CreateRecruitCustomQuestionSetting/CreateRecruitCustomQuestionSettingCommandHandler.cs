using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.RecruitCustomQuestionSettings.Commands.CreateRecruitCustomQuestionSetting;

internal class CreateRecruitCustomQuestionSettingCommandHandler(
    IGenericRepository<RecruitCustomQuestionSetting> recruitCustomQuestionSettingRepository) : IRequestHandler<CreateRecruitCustomQuestionSettingCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateRecruitCustomQuestionSettingCommand request, CancellationToken cancellationToken)
    {
        var recruitCustomQuestionSetting = new RecruitCustomQuestionSetting
        {
            CQQuestion = request.CQQuestion,
            CustomQuestionTypeId = request.CustomQuestionTypeId,
            CustomQuestionCategoryId = request.CustomQuestionCategoryId,
            CQStatusId = request.CQStatusId,
            CQIsRequiredId = request.CQIsRequiredId,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await recruitCustomQuestionSettingRepository.CreateAsync(recruitCustomQuestionSetting);
    }
}
























