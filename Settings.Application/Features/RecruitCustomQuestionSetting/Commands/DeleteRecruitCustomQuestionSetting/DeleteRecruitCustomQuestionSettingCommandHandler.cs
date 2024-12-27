using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.RecruitCustomQuestionSettings.Commands.DeleteRecruitCustomQuestionSetting;

internal class DeleteRecruitCustomQuestionSettingCommandHandler : IRequestHandler<DeleteRecruitCustomQuestionSettingCommand>
{
    private readonly IGenericRepository<RecruitCustomQuestionSetting> _recruitCustomQuestionSettingRepository;

    public DeleteRecruitCustomQuestionSettingCommandHandler(
        IGenericRepository<RecruitCustomQuestionSetting> recruitCustomQuestionSettingRepository) =>
        _recruitCustomQuestionSettingRepository = recruitCustomQuestionSettingRepository;
    public async System.Threading.Tasks.Task Handle(DeleteRecruitCustomQuestionSettingCommand request, CancellationToken cancellationToken)
    {
        await _recruitCustomQuestionSettingRepository.DeleteAsync(request.Id);
    }
}
























