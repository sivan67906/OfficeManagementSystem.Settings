using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.RecruitFooterSettings.Commands.DeleteRecruitFooterSetting;

internal class DeleteRecruitFooterSettingCommandHandler : IRequestHandler<DeleteRecruitFooterSettingCommand>
{
    private readonly IGenericRepository<RecruitFooterSetting> _recruitFooterSettingRepository;

    public DeleteRecruitFooterSettingCommandHandler(
        IGenericRepository<RecruitFooterSetting> recruitFooterSettingRepository) =>
        _recruitFooterSettingRepository = recruitFooterSettingRepository;
    public async System.Threading.Tasks.Task Handle(DeleteRecruitFooterSettingCommand request, CancellationToken cancellationToken)
    {
        await _recruitFooterSettingRepository.DeleteAsync(request.Id);
    }
}
























