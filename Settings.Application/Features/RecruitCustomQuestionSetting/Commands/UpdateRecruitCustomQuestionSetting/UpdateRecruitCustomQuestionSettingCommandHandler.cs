using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.RecruitCustomQuestionSettings.Commands.UpdateRecruitCustomQuestionSetting;

internal class UpdateRecruitCustomQuestionSettingCommandHandler : IRequestHandler<UpdateRecruitCustomQuestionSettingCommand>
{
    private readonly IGenericRepository<RecruitCustomQuestionSetting> _recruitCustomQuestionSettingRepository;

    public UpdateRecruitCustomQuestionSettingCommandHandler(
        IGenericRepository<RecruitCustomQuestionSetting> recruitCustomQuestionSettingRepository) =>
        _recruitCustomQuestionSettingRepository = recruitCustomQuestionSettingRepository;

    public async System.Threading.Tasks.Task Handle(UpdateRecruitCustomQuestionSettingCommand request, CancellationToken cancellationToken)
    {
        var recruitCustomQuestionSetting = new RecruitCustomQuestionSetting
        {
            Id = request.Id,
            CQQuestion = request.CQQuestion,
            CustomQuestionTypeId = request.CustomQuestionTypeId,
            CustomQuestionCategoryId = request.CustomQuestionCategoryId,
            CQStatusId = request.CQStatusId,
            CQIsRequiredId = request.CQIsRequiredId,
            UpdatedDate = DateTime.Now
        };

        await _recruitCustomQuestionSettingRepository.UpdateAsync(recruitCustomQuestionSetting);
    }
}
























